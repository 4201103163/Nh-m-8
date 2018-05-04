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
    public partial class fmCapNhapNCC : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhapNCC()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public fmCapNhapNCC(string ma, string ten, string sdt, string dc, string gc)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtSDT.Text = sdt;                        
            txtDiaChi.Text = dc;
            txtGhiChu.Text = gc;            
            btUpdate.Text = "Sửa";
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
                string dc = txtDiaChi.Text;
                string gc = txtGhiChu.Text;     

                string sql1 = "insert into NHOMNHACUNGCAP values('" + ma + "','" + ten + "','"+sdt+",'"+dc+"','"+gc+"'')"; 
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
            else //danh cho lenh Sua
            {
                DBService db = new DBService();
                db.openconn();
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string dc = txtDiaChi.Text;
                string gc = txtGhiChu.Text;
                string sql1 = "update NHOMNHACUNGCAP SET NCC_name = N'" + ten + "', NCC_number '"+sdt+"', NCC_address = N'"+dc+"', NCC_note = N'"+gc+"'where NCC_id = '"+ma+"'"; 
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