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
    public partial class fmBaoCaoNo : DevExpress.XtraEditors.XtraForm
    {
        public fmBaoCaoNo()
        {
            InitializeComponent();
        }

        private void fmBaoCaoNo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataBaoCaoNo.BCN' table. You can move, or remove it, as needed.
            this.BCNTableAdapter.Fill(this.DataBaoCaoNo.BCN);

            this.reportViewer1.RefreshReport();
        }
    }
}