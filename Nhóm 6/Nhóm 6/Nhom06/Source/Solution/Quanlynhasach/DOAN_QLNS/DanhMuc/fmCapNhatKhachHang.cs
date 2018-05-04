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
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace DOAN_QLNS
{
    public partial class fmCapNhatKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhatKhachHang()
        {
            InitializeComponent();
            btUpdate.Text = "Thêm";
        }
        public fmCapNhatKhachHang(string ma, string ten, string sdt, string mail, float score, string gc)
        {
            InitializeComponent();
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtSDT.Text = sdt;
            txtMail.Text = mail;
            txtSoTienNo.Text = score.ToString();
            txtGhiChu.Text = gc;
            btUpdate.Text = "Sửa";
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            if(reg.IsMatch(txtMail.Text))
            {
                this.errorProvider1.SetError(txtMail, (string)null);
            }
            else
            {
                this.errorProvider1.SetError(txtMail, "Error");
            }
            if (btUpdate.Text == "Thêm")
            {
                DBService db = new DBService();
                db.openconn();

                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string email = txtMail.Text;
                float sotienno = float.Parse(txtSoTienNo.Text.ToString());
                string ghichu = txtGhiChu.Text;
                string sql = "insert into KHACHHANG values('" + ma + "',N'" + ten + "', '"+sdt+"', '"+email+"', "+sotienno+", N'"+ghichu+"')"; 
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
                MessageBox.Show("Thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
            else //danh cho lenh Sua
            {
                DBService db = new DBService();
                db.openconn();
                string ma = txtMa.Text;
                string ten = txtTen.Text;
                string sdt = txtSDT.Text;
                string email = txtMail.Text;
                float sotienno = float.Parse(txtSoTienNo.Text.ToString());
                string ghichu = txtGhiChu.Text;
                string sql = "update KhachHang SET KH_name = N'" + ten + "', KH_number = '"+ sdt +"', KH_mail = '" + email + "' , KH_scores = "+ sotienno +" , KH_note = N'" + ghichu + "' WHERE NV_id = '" + ma + "'"; // them vao bang nv
                SqlCommand cmd = new SqlCommand(sql, db.conn);
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
                MessageBox.Show("Cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}