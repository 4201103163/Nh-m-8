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

namespace DOAN_QLNS
{
    public partial class fmCapNhatNgayLapPhieu : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhatNgayLapPhieu()
        {
            InitializeComponent();
        }
        public fmCapNhatNgayLapPhieu(string ma, string ngay)
        {
            InitializeComponent();
            txtMa.Text = ma;
            dati.Value = Convert.ToDateTime(ngay);
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            PHIEUNHAP pn = new PHIEUNHAP(txtMa.Text, Convert.ToDateTime(dati.Text));
            pn.Sua();
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}