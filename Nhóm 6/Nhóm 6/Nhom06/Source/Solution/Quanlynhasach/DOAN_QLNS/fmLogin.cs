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
using System.Threading;
using System.Reflection;
using System.Resources;
using System.Globalization;
namespace DOAN_QLNS
{
    public partial class fmLogin : DevExpress.XtraEditors.XtraForm
    {
        public fmLogin()
        {
            InitializeComponent();
        }
        string pq;
        private void showFMAdmin()
        {
            fmAdmin qlns = new fmAdmin(pq);
            qlns.ShowDialog();
        }

        private void cbGhiNhoTK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGhiNhoTK.Checked)
            {
                Properties.Settings.Default.users = txtTenDangNhap.Text;
                Properties.Settings.Default.users = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.users = "";
                Properties.Settings.Default.users = "";
                Properties.Settings.Default.Save();
            }
        }

        private void cbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienThiMatKhau.Checked == true)
                txtMatKhau.UseSystemPasswordChar = false;
            else
                txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DBService db = new DBService();
            db.openconn();
            string t = "select l.*,nv.NV_name from TaiKhoan l inner join NhanVien nv on l.NV_id = nv.NV_id where l.Username = '" + txtTenDangNhap.Text + "' and l.Pass = '" + txtMatKhau.Text + "'";
            SqlDataReader rd = db.getDataReader(t);
            if (rd.HasRows)
            {
                rd.Read();
                if (rd.GetString(1) == txtTenDangNhap.Text && rd.GetString(2) == txtMatKhau.Text)
                {

                    MessageBox.Show("Đăng nhập thành công.\nChào " + rd.GetString(4), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pq = rd.GetString(3);
                    this.Hide();
                    if (rd.GetString(2) == "Admin")
                    {
                        fmAdmin qlns = new fmAdmin();
                        qlns.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        fmAdmin qlns = new fmAdmin(pq);
                        qlns.ShowDialog();
                    }
                    txtTenDangNhap.Text = "";
                    txtMatKhau.Text = "";

                }
                else MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            db.closeconn();           
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.users;
            txtMatKhau.Text = Properties.Settings.Default.pass;
            lblNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Start();
        }
        int x = 3, y = 106, a = 1;
        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lblText.Location = new Point(x, y);
                if(x >= 563)
                {
                    a = -1;
                    lblText.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if(x <= 3)
                {
                    a = 1;
                    lblText.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch(Exception ex)
            {

            }
            lblGio.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("DOAN_QLNS");
            ResourceManager rm = new ResourceManager("DOAN_QLNS.Lang.langEn", a);
            lblDangNhapHeThong.Text = rm.GetString("signin", ci);
            lblTenDangNhap.Text = rm.GetString("account", ci);
            lblMatKhau.Text = rm.GetString("password", ci);
            btnDangNhap.Text = rm.GetString("submit", ci);
            btnThoat.Text = rm.GetString("exit", ci);
            cbGhiNhoTK.Text = rm.GetString("reaccount", ci);
            cbHienThiMatKhau.Text = rm.GetString("spassword", ci);
        }

        private void getRes1(CultureInfo ci)
        {
            Assembly a = Assembly.Load("DOAN_QLNS");
            ResourceManager rm = new ResourceManager("DOAN_QLNS.Lang.langVn", a);
            lblDangNhapHeThong.Text = rm.GetString("signin", ci);
            lblTenDangNhap.Text = rm.GetString("account", ci);
            lblMatKhau.Text = rm.GetString("password", ci);
            btnDangNhap.Text = rm.GetString("submit", ci);
            btnThoat.Text = rm.GetString("exit", ci);
            cbGhiNhoTK.Text = rm.GetString("reaccount", ci);
            cbHienThiMatKhau.Text = rm.GetString("spassword", ci);
        }
        private void btnEn_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            getRes(ci);
        }

        private void btnVi_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("vi-VN");
            getRes1(ci);
        }
    }
}