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
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace DOAN_QLNS
{
    public partial class fmTuSach : DevExpress.XtraEditors.XtraForm
    {
        CultureInfo culture;
        
        public fmTuSach()
        {
            InitializeComponent();
            culture = CultureInfo.CurrentCulture;
        }
       
        private void getRes(CultureInfo ci)
        {
            Assembly a = Assembly.Load("DOAN_QLNS");
            ResourceManager rm = new ResourceManager("DOAN_QLNS.Lang.langEn", a);
            bttKD.Text = rm.GetString("horror", ci);
            bttTN.Text = rm.GetString("children", ci);
            bttTT.Text = rm.GetString("novel", ci);
            bttTNN.Text = rm.GetString("tale", ci);
            bttKN.Text = rm.GetString("skill", ci);
            bttKT.Text = rm.GetString("economy", ci);
            bttNC.Text = rm.GetString("upbringing", ci);
            bttNA.Text = rm.GetString("cooking", ci);
            bttCNTT.Text = rm.GetString("computer", ci);
            bttTL.Text = rm.GetString("psychology", ci);      
        }

        private void getRes1(CultureInfo ci)
        {
            Assembly a = Assembly.Load("DOAN_QLNS");
            ResourceManager rm = new ResourceManager("DOAN_QLNS.Lang.langVn", a);
            bttKD.Text = rm.GetString("horror", ci);
            bttTN.Text = rm.GetString("children", ci);
            bttTT.Text = rm.GetString("novel", ci);
            bttTNN.Text = rm.GetString("tale", ci);
            bttKN.Text = rm.GetString("skill", ci);
            bttKT.Text = rm.GetString("economy", ci);
            bttNC.Text = rm.GetString("upbringing", ci);
            bttNA.Text = rm.GetString("cooking", ci);
            bttCNTT.Text = rm.GetString("computer", ci);
            bttTL.Text = rm.GetString("psychology", ci);
            btnTimKiem.Text = rm.GetString("search", ci);
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
        private void bttKD_Click(object sender, EventArgs e)
        {
            fmTuSachKinhDi fm = new fmTuSachKinhDi();
            fm.ShowDialog();
        }

        private void bttTT_Click(object sender, EventArgs e)
        {
            fmTuSachTieuThuyet fm = new fmTuSachTieuThuyet();
            fm.ShowDialog();
        }

        private void bttTNN_Click(object sender, EventArgs e)
        {
            fmTuSachTruyenNgan fm = new fmTuSachTruyenNgan();
            fm.ShowDialog();
        }

        private void bttKN_Click(object sender, EventArgs e)
        {
            fmTuSachKyNang fm = new fmTuSachKyNang();
            fm.ShowDialog();
        }

        private void bttTN_Click(object sender, EventArgs e)
        {
            fmTuSachThieuNhi fm = new fmTuSachThieuNhi();
            fm.ShowDialog();
        }

        private void bttKT_Click(object sender, EventArgs e)
        {
            fmTuSachKinhTe fm = new fmTuSachKinhTe();
            fm.ShowDialog();
        }

        private void bttNC_Click(object sender, EventArgs e)
        {
            fmNuoiDayCon fm = new fmNuoiDayCon();
            fm.ShowDialog();
        }

        private void bttNA_Click(object sender, EventArgs e)
        {
            fmTuSachNauAn fm = new fmTuSachNauAn();
            fm.ShowDialog();
        }

        private void bttCNTT_Click(object sender, EventArgs e)
        {
            fmTuSachCNTT fm = new fmTuSachCNTT();
            fm.ShowDialog();
        }

        private void bttTL_Click(object sender, EventArgs e)
        {
            fmTuSachTamLy fm = new fmTuSachTamLy();
            fm.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            fmSach_KH fm = new fmSach_KH();
            fm.ShowDialog();
        }

    

    }
}