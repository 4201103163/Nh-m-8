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
    public partial class fmReportPhieuThuTien : DevExpress.XtraEditors.XtraForm
    {
        public fmReportPhieuThuTien()
        {
            InitializeComponent();
        }
        string k;
        public fmReportPhieuThuTien(string ten)
        {
            InitializeComponent();
            k = ten;
        }

        private void fmReportPhieuThuTien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataBaoCaoNo.PTT' table. You can move, or remove it, as needed.
            this.PTTTableAdapter.Fill(this.DataBaoCaoNo.PTT, k);
            this.reportViewer1.RefreshReport();
        }
       
    }
}