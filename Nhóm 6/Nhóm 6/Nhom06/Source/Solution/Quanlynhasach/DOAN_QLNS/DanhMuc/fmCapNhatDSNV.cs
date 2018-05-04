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

namespace DOAN_QLNS
{
    public partial class fmCapNhatDSNV : DevExpress.XtraEditors.XtraForm
    {
        string imageLocation = "";  
        public fmCapNhatDSNV()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";
        }
        public fmCapNhatDSNV(string ma,string ten,string gt, DateTime ns, DateTime nvl, string sdt, string dc, string gc, string user, string pass, string chucvu)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
            cbGioiTinh.Text = gt;
            datipickNgaySinh.Value = ns;
            datipickNgayLam.Value = nvl;
            txtSDT.Text = sdt;
            txtDiaChi.Text = dc;
            txtGhiChu.Text = gc;
            txtUsername.Text = user;
            txtPassword.Text = pass;
            txtChucVu.Text = chucvu;
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
                string gt = cbGioiTinh.Text;
                DateTime ns = datipickNgaySinh.Value;
                DateTime nl = datipickNgayLam.Value;
                string sdt = txtSDT.Text;
                string chucvu = txtChucVu.Text;
                string diachi = txtDiaChi.Text;
                string ghichu = txtGhiChu.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                string sql1 = "insert into NHANVIEN values('" +ma+ "',N'" + ten + "',CONVERT(DATETIME,'" + ns.ToString("dd/MM/yyyy") + "',103),CONVERT(DATETIME,'" + nl.ToString("dd/MM/yyyy") + "',103),'" + sdt + "',N'" + diachi + "',N'" + ghichu + "','"+gt+"')"; // them vao bang nv
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


                string sql2 = "insert into TAIKHOAN values('"+ma+"','"+username+"','"+password+"','"+chucvu+"')"; // them vao bang taikhoan                
                SqlCommand cmd2 = new SqlCommand(sql2, db.conn);
                //đánh dấu điểm bắt đầu               
                SqlTransaction tran2 = db.conn.BeginTransaction("ThemLopTransaction");
                cmd2.Transaction = tran2;
                try
                {                  
                    cmd2.ExecuteNonQuery();
                    tran2.Commit();//kết thúc transaction
                }
                catch (Exception ex)
                {                    
                    tran2.Rollback();
                    throw ex;
                }

                string sqlQuery = "insert into BioData values ('"+ma+"',N'"+pictureBox1.ImageLocation+"')";
                SqlCommand cmd = new SqlCommand(sqlQuery, db.conn);
                SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
                cmd.Transaction = tran;                
                try
                {
                    cmd.ExecuteNonQuery();
                    tran.Commit();//kết thúc transaction
                }
                catch (Exception ex)
                {
                    tran.Rollback();
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
                    string gt = cbGioiTinh.Text;
                    DateTime ns = datipickNgaySinh.Value;
                    DateTime nl = datipickNgayLam.Value;
                    string sdt = txtSDT.Text;
                    string chucvu = txtChucVu.Text;
                    string diachi = txtDiaChi.Text;
                    string ghichu = txtGhiChu.Text;
                    string username = txtUsername.Text;
                    string password = txtPassword.Text;

                    string sql1 = "update NhanVien SET NV_name = N'"+ten+"', NV_birthday = CONVERT(DATETIME,'"+ns+"',103), NV_datework = CONVERT(DATETIME,'"+nl+"',103), NV_number = '"+sdt+"' , NV_address = N'"+diachi+"' , NV_note = N'"+ghichu+"', NV_gender = '"+gt+"' WHERE NV_id = '"+ma+"'"; // them vao bang nv
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


                    string sql2 = "update TaiKhoan SET Username = '"+username+"', Pass = '"+password+"', Acc_Type = '"+chucvu+"' where NV_id = '"+ma+"'"; 
                    SqlCommand cmd2 = new SqlCommand(sql2, db.conn);
                    //đánh dấu điểm bắt đầu               
                    SqlTransaction tran2 = db.conn.BeginTransaction("ThemLopTransaction");
                    cmd2.Transaction = tran2;
                    try
                    {
                        cmd2.ExecuteNonQuery();
                        tran2.Commit();//kết thúc transaction
                    }
                    catch (Exception ex)
                    {
                        tran2.Rollback();
                        throw ex;
                    }
                    db.closeconn();
                    MessageBox.Show("Cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            }
        }

        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imageLocation;
            }
        }
    }
}