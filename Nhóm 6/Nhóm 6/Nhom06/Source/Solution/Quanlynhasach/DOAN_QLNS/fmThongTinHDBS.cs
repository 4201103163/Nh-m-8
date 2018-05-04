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
    public partial class fmThongTinHDBS : DevExpress.XtraEditors.XtraForm
    {
        string maphd = DateTime.Now.ToString("ddMMhhmmss");
        public fmThongTinHDBS()
        {
            InitializeComponent();
            btEditMa.Text = maphd;
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
                txtDiaChi.Text = rd.GetString(4);
                txtSDT.Text = rd.GetString(2);
                txtEmail.Text = rd.GetString(3);
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
                txtDiaChi.Text = rd.GetString(4);
                txtSDT.Text = rd.GetString(2);
                txtEmail.Text = rd.GetString(3);
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

        private void txtTen_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!timKH_TheoTen(txtTen.Text)) MessageBox.Show("Không tồn tại tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditMa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btEditMa.Text = maphd;
        }
        public bool ktMaHD(string ma)
        {
            string sql = "select * from HOADON where HD_id = '" + ma + "'";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            if (rd.HasRows) return true;
            return false;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (timKH_TheoMa(txtMa.Text) == false || timKH_TheoTen(txtTen.Text) == false)
            {
                MessageBox.Show("Không tồn tại mã hay tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ktMaHD(btEditMa.Text)) MessageBox.Show("Mã phiếu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if(int.Parse(txtSTN.Text) > notoida)
                    {
                        MessageBox.Show("Vi phạm điều kiện trong lưu ý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    PHIEUHOADON phd = new PHIEUHOADON(btEditMa.Text, txtMa.Text, datiNgayLap.Value);
                    phd.Them();
                    this.Hide();
                    fmHoaDonBS hdbs = new fmHoaDonBS(btEditMa.Text, txtTen.Text, txtMa.Text, datiNgayLap.Text);
                    hdbs.ShowDialog();
                    this.Close();
                }
            }
        }
        int notoida;
        private void fmThongTinHDBS_Load(object sender, EventArgs e)
        {
            string sql = "select * from QUYDINH";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            rd.Read();
            notoida = rd.GetInt32(2);
            db.closeconn();

            lblTienNoKH.Text = notoida.ToString();
        }
    }
}