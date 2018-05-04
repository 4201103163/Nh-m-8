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
    public partial class fmPhieuThuTien : DevExpress.XtraEditors.XtraForm
    {
        string mapt = DateTime.Now.ToString("ddMMhhmmss");
        public fmPhieuThuTien()
        {
            InitializeComponent();
            btEditMa.Text = mapt;
        }
        public fmPhieuThuTien(string _mpt, string _mkh, string stt)
        {
            InitializeComponent();
            btEditMa.Text = _mpt;
            btEditMa.Enabled = false;
            btXacNhan.Visible = false;
            btReport.Text = "Sửa";
            btReport.Enabled = true;
            txtSTT.Text = stt;
            timKH_TheoMa(_mkh);
        }
        public bool timKH_TheoMa(string ma)
        {
            string sql = "select * from KHACHHANG where KH_id = '" + ma + "'";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.HasRows)
            {
                rd.Read();
                txtMa.Text = rd.GetString(0);
                txtTen.Text = rd.GetString(1);
                txtSDT.Text = rd.GetString(2);
                txtEmail.Text = rd.GetString(3);
                txtDiaChi.Text = rd.GetString(4);              
                txtSTN.Text = rd.GetDouble(5).ToString();
                return true;
            }
            db.closeconn();
            return false;
        }
        public bool timKH_TheoTen(string ten)
        {
            string sql = "select * from KHACHHANG where KH_name = N'" + ten + "'";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.HasRows)
            {
                rd.Read();
                txtMa.Text = rd.GetString(0);
                txtTen.Text = rd.GetString(1);
                txtSDT.Text = rd.GetString(2);
                txtEmail.Text = rd.GetString(3);
                txtDiaChi.Text = rd.GetString(4);
                txtSTN.Text = rd.GetDouble(5).ToString();
                return true;
            }
            db.closeconn();
            return false;
        }

        private void txtMa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!timKH_TheoMa(txtMa.Text)) MessageBox.Show("Không tồn tại mã khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!timKH_TheoTen(txtTen.Text)) MessageBox.Show("Không tồn tại tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool ktMaPTT(string ma)
        {
            string sql = "select * from PHIEUTHUTIEN where PhieuThuTien_id = '" + ma + "'";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.HasRows) return true;
            return false;
        }

        private void fmPhieuThuTien_Load(object sender, EventArgs e)
        {
            string sql = "select * from QUYDINH";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            rd.Read();
            lblQD4.Visible = rd.GetBoolean(4);
            db.closeconn();
        }

        private void btDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXacNhan_Click_1(object sender, EventArgs e)
        {
            if (btXacNhan.Text == "Nhập mới")
            {
                btXacNhan.Text = "Xác nhận";
                groupControl1.Enabled = datiNgayLap.Enabled = txtSTT.Enabled = btEditMa.Enabled = true;
                txtMa.Text = txtTen.Text = txtDiaChi.Text = txtSDT.Text = txtEmail.Text = txtSTN.Text = txtSTT.Text = "";
                mapt = DateTime.Now.ToString("ddMMhhmmss");
                btReport.Enabled = false;
                btEditMa.Text = mapt;
                return;
            }

            if (txtMa.Text == "" || btEditMa.Text == "" || txtSTT.Text == "")
                MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (timKH_TheoMa(txtMa.Text) == false || timKH_TheoTen(txtTen.Text) == false) MessageBox.Show("Mã hoặc tên khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (ktMaPTT(btEditMa.Text)) MessageBox.Show("Mã phiếu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (lblQD4.Visible)
                    {
                        if (int.Parse(txtSTT.Text) > int.Parse(txtSTN.Text))
                        {
                            MessageBox.Show("Vi phạm lưu ý!", "Thông cáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                    }
                    PHIEUTHUTIEN ptt = new PHIEUTHUTIEN(btEditMa.Text, float.Parse(txtSTT.Text.Trim()), Convert.ToDateTime(datiNgayLap.Text), txtMa.Text);
                    ptt.Them();
                    MessageBox.Show("Thêm phiếu thu tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KHACHHANG kh = new KHACHHANG(txtMa.Text, "", "", "", "", float.Parse(txtSTT.Text));
                    kh.Sua_STN_Giam();

                    btReport.Enabled = true;

                    groupControl1.Enabled = datiNgayLap.Enabled = txtSTT.Enabled = btEditMa.Enabled = false;
                    btXacNhan.Text = "Nhập mới";
                }
            }
        }

        private void btEditMa_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btEditMa.Text = mapt;
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            if (btReport.Text == "Xuất report")
            {
                string t = txtTen.Text;
                fmReportPhieuThuTien hd = new fmReportPhieuThuTien(t);
                hd.ShowDialog();
            }
            else // lệnh cho hàm sửa PTT bên form DSPTT
            {
                PHIEUTHUTIEN xoa_ptt = new PHIEUTHUTIEN(btEditMa.Text, 0, DateTime.Now, "");
                xoa_ptt.Xoa();
                if (txtMa.Text == "" || btEditMa.Text == "" || txtSTT.Text == "")
                    MessageBox.Show("Chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (timKH_TheoMa(txtMa.Text) == false || timKH_TheoTen(txtTen.Text) == false) MessageBox.Show("Mã hoặc tên khách hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else if (ktMaPTT(btEditMa.Text)) MessageBox.Show("Mã phiếu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        PHIEUTHUTIEN ptt = new PHIEUTHUTIEN(btEditMa.Text, float.Parse(txtSTT.Text.Trim()), Convert.ToDateTime(datiNgayLap.Text), txtMa.Text);
                        ptt.Them();
                        MessageBox.Show("Sửa phiếu thu tiền thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}