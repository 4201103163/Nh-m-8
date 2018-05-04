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
    public partial class frm_Report_HDBS : DevExpress.XtraEditors.XtraForm
    {
        public frm_Report_HDBS()
        {
            InitializeComponent();
        }
        string ten, ngay;
        public frm_Report_HDBS(string t, string n)
        {
            InitializeComponent();
            ten = t;
            ngay = n;
        }
        private void frm_Report_HDBS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataBaoCaoNo.HD' table. You can move, or remove it, as needed.
            this.HDTableAdapter.Fill(this.DataBaoCaoNo.HD, ten);

            this.reportViewer1.RefreshReport();
        }
    }
}