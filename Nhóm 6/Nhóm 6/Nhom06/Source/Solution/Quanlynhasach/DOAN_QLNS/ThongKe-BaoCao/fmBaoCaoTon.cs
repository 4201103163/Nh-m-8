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
    public partial class fmBaoCaoTon : DevExpress.XtraEditors.XtraForm
    {
        public fmBaoCaoTon()
        {
            InitializeComponent();
        }

        private void fmBaoCaoTon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataBaoCaoTon.BCT' table. You can move, or remove it, as needed.
            this.BCTTableAdapter.Fill(this.DataBaoCaoTon.BCT);

            this.reportViewer1.RefreshReport();
        }
    }
}