using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace DOAN_QLNS
{
    public partial class fmCapNhatTacGia : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhatTacGia()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";            
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public fmCapNhatTacGia(string ma, string ten, string gc)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;       
            txtGhiChu.Text = gc;            
            btUpdate.Text = "Sửa";
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (btUpdate.Text == "Thêm")
            {
                DBService db = new DBService();
                db.openconn();               

                string sql = "insert into NHOMTACGIA values (@NTG_id, @NTG_name, @NTG_note, @Picture)";
                SqlCommand conn = new SqlCommand(sql, db.conn);
                conn.Parameters.AddWithValue("@NTG_id", txtMa.Text);
                conn.Parameters.AddWithValue("@NTG_name", txtTen.Text);
                conn.Parameters.AddWithValue("@NTG_note", txtGhiChu.Text);
                conn.Parameters.AddWithValue("@Picture", convertImageToBytes());
                SqlTransaction tran2 = db.conn.BeginTransaction("ThemLopTransaction");
                conn.Transaction = tran2;
                try
                {
                    conn.ExecuteNonQuery();
                    tran2.Commit();//kết thúc transaction                   
                }
                catch (Exception ex)
                {
                    tran2.Rollback();//quay lui tới thời điểm beginTran                    
                    throw ex;
                }             

                db.closeconn();
                MessageBox.Show("Thêm thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //danh cho lenh Sua
            {
                DBService db = new DBService();
                db.openconn();
                string ma = txtMa.Text;
                string ten = txtTen.Text;            
                string gc = txtGhiChu.Text;
                string sql1 = "update NHOMTACGIA SET NTG_name = N'" + ten + "', NTG_note = N'" + gc + "' where NTG_id = '" + ma + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, db.conn);
                SqlTransaction tran1 = db.conn.BeginTransaction("ThemLopTransaction");
                cmd1.Transaction = tran1;
                try
                {
                    cmd1.ExecuteNonQuery();
                    tran1.Commit();//kết thúc transaction                   
                }
                catch (Exception ex)
                {
                    tran1.Rollback();//quay lui tới thời điểm beginTran                    
                    throw ex;
                }
                db.closeconn();
                MessageBox.Show("Cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {          
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = open.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            open.FilterIndex = 1;
            open.RestoreDirectory = true;
            if(open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = open.FileName;
                txtAnh.Text = open.FileName;
            }

        }

      
        private byte[] convertImageToBytes()
        {
            FileStream fm;
            fm = new FileStream(txtAnh.Text, FileMode.Open, FileAccess.Read);
            byte[] pictureBox1 = new byte[fm.Length];
            fm.Read(pictureBox1, 0, System.Convert.ToInt32(fm.Length));
            fm.Close();
            return pictureBox1;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DBService db = new DBService();
                db.openconn();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("Select * from NHOMTACGIA", db.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                db.closeconn();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }
      
    }
}