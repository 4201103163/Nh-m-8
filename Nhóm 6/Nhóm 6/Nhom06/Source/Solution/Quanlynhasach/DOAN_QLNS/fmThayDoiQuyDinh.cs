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
    public partial class fmThayDoiQuyDinh : DevExpress.XtraEditors.XtraForm
    {
        public fmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            QUYDINH ts = new QUYDINH(long.Parse(txtQD11_LNTT.Text), long.Parse(txtQD12_LTTT_TN.Text), long.Parse(txtQD21_TNTD.Text), long.Parse(txtQD22_LTTT_SB.Text), nutDieuCinh.IsOn);
            ts.Sua();
            MessageBox.Show("Cập nhật quy định thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void fmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
          
        }

    }
}