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
using System.Threading;
using System.Data.SqlClient;

namespace DOAN_QLNS
{
    public partial class fmThongTinPNS : DevExpress.XtraEditors.XtraForm
    {
        public fmThongTinPNS()
        {
            InitializeComponent();
        }
        string ma = DateTime.Now.ToString("ddMMhhmmss");
        private void fmThongTinPNS_Load(object sender, EventArgs e)
        {
            btEditMa.Text = ma;
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showFrmPNS()
        {
            fmLapPhieuNhap pns = new fmLapPhieuNhap(btEditMa.Text, dati.Text);
            pns.ShowDialog();
        }

        DB_PHIEUNHAP db = new DB_PHIEUNHAP();
        bool exist_MaPN(string ma)
        {
            SqlDataReader rd = db.Tim_TheoMa(ma);
            if (rd.HasRows) return true;
            return false;
        }
        bool exist_NgayPN(string ngay)
        {
            SqlDataReader rd = db.Tim_TheoNgay(ngay);
            if (rd.HasRows) return true;
            return false;
        }
        private void btLapPhieu_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(new ThreadStart(showFrmPNS));
            //th.Start();
            //this.Close();
            if (btEditMa.Text == "" || dati.Text == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin phiếu nhập !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!exist_MaPN(btEditMa.Text))
                {
                    if (exist_NgayPN(dati.Text))
                    {
                        DialogResult dr = MessageBox.Show("Ngày " + dati.Text + " đã có phiếu nhập, bạn có chắc muốn nhập thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr != DialogResult.Yes) return;
                    }

                    PHIEUNHAP pn = new PHIEUNHAP(btEditMa.Text, Convert.ToDateTime(dati.Text));
                    pn.Them();
                    fmLapPhieuNhap pns = new fmLapPhieuNhap(btEditMa.Text, dati.Text);
                    this.Hide();
                    pns.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btEditMa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btEditMa.Text = ma;
        }

       
    }
}