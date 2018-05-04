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

namespace DOAN_QLNS
{
    public partial class fmCapNhatNhaXuatBan : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhatNhaXuatBan()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";
        }
        public fmCapNhatNhaXuatBan(string ma, string ten,string sdt, string dc, string gc)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;          
            txtSDT.Text = sdt;
            txtDiaChi.Text = dc;
            txtGhiChu.Text = gc;         
            btUpdate.Text = "Sửa";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (btUpdate.Text == "Thêm")
            {
                DBService db = new DBService();
                db.openconn();
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string ghichu = txtGhiChu.Text;

                string sql1 = "insert into NHOMNHAXUATBAN values('" + ma + "',N'" + ten + "',N'" + sdt + "',N'" + diachi + "',N'" + ghichu + "')";
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
                MessageBox.Show("Thêm thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
            }
            else
            {
                DBService db = new DBService();
                db.openconn();
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string diachi = txtDiaChi.Text;
                string ghichu = txtGhiChu.Text;

                string sql1 = "update NHOMNHAXUATBAN SET NXB_name = N'" + ten + "', NXB_number = '" + sdt + "' , NXB_address = N'" + diachi + "' , NXB_note = N'" + ghichu + "'WHERE NXB_id = '" + ma + "'"; 
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
    }
}