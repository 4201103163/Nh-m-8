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
    public partial class fmCapNhatTheLoaiSach : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhatTheLoaiSach()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";
        }
        public fmCapNhatTheLoaiSach(string ma, string ten, string gc)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
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
                string gc = txtGhiChu.Text;

                string sql = "insert into NHOMTHELOAI values('"+ma+"', N'"+ten+"', N'"+gc+"')";                                
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                
                //đánh dấu điểm bắt đầu
                SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
                cmd.Transaction = tran;
                
                try
                {
                    cmd.ExecuteNonQuery();
                    tran.Commit();//kết thúc transaction
                    
                }
                catch (Exception ex)
                {
                    tran.Rollback();//quay lui tới thời điểm beginTran                    
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
                string sql1 = "update NHOMTHELOAI SET NTL_name = N'" + ten + "', NTL_note = N'"+gc+"'where NTL_id = '"+ma+"'";
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