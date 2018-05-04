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
    public partial class fmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public fmChangePassword()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLNS;Integrated Security=True");
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ASDF = new SqlDataAdapter("SELECT COUNT(*) FROM TaiKhoan WHERE Username = '" + txtUsername.Text + "'AND Pass = '" + txtMKHienTai.Text + "'", conn);
            DataTable DS = new DataTable();
            ASDF.Fill(DS);
            errorProvider1.Clear();
            if(DS.Rows[0][0].ToString() == "1")
            {
                if (txtMKMoi.Text == txtNhapLaiMK.Text)
                {
                    //SqlDataAdapter cc = new SqlDataAdapter("update TaiKhoan set Pass = '" + txtMKMoi.Text + "'where Username = '" + txtUsername.Text + "' and Pass = '" + txtMKHienTai.Text + "'", conn);
                    DBService db = new DBService();
                    db.openconn();
                    string sql = "update TaiKhoan set Pass = '" + txtMKMoi.Text + "'where Username = '" + txtUsername.Text + "' and Pass = '" + txtMKHienTai.Text + "'";
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
                    MessageBox.Show("Password Changed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    errorProvider1.SetError(txtMKMoi,"Unmatch Password ");
                    errorProvider1.SetError(txtNhapLaiMK, "Unmatch Password");
                }
            }
            else
            {
                errorProvider1.SetError(txtUsername, "incorrect user name");
                errorProvider1.SetError(txtMKHienTai, "incorrect password");
            }
        }

    }
}