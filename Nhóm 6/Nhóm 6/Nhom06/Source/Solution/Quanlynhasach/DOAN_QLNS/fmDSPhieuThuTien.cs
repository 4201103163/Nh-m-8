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
    public partial class fmDSPhieuThuTien : DevExpress.XtraEditors.XtraForm
    {
        public fmDSPhieuThuTien()
        {
            InitializeComponent();
            load_DSKH();
        }
        public void load_DSKH()
        {
    
        }

        public void load_DSPTT_TheoMaKH(string ma)
        {
    
        }

        private void gView_DSKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            load_DSPTT_TheoMaKH(gView_DSKH.GetRowCellValue(gView_DSKH.FocusedRowHandle, "Mã KH").ToString());
        }

        private void gCtrl_DSPTT_DataSourceChanged(object sender, EventArgs e)
        {
            if (gView_DSPTT.SelectedRowsCount > 0)
            {
                btSua.Enabled = btXoa.Enabled = true;
            }
            else
            {
                btSua.Enabled = btXoa.Enabled = false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            PHIEUTHUTIEN ptt = new PHIEUTHUTIEN(gView_DSPTT.GetRowCellValue(gView_DSPTT.FocusedRowHandle, "Mã phiếu thu").ToString(), 0, DateTime.Now, "");
            ptt.Xoa();
            load_DSPTT_TheoMaKH(gView_DSKH.GetRowCellValue(gView_DSKH.FocusedRowHandle, "Mã KH").ToString());
        }

        private void gCtrl_DSKH_DataSourceChanged(object sender, EventArgs e)
        {
            if (gView_DSKH.SelectedRowsCount > 0) load_DSPTT_TheoMaKH(gView_DSKH.GetRowCellValue(gView_DSKH.FocusedRowHandle, "Mã KH").ToString());
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            fmPhieuThuTien ptt = new fmPhieuThuTien(gView_DSPTT.GetRowCellValue(gView_DSPTT.FocusedRowHandle, "Mã phiếu thu").ToString(), gView_DSKH.GetRowCellValue(gView_DSKH.FocusedRowHandle, "Mã KH").ToString(), gView_DSPTT.GetRowCellValue(gView_DSPTT.FocusedRowHandle, "Số tiền thu").ToString());
            ptt.ShowDialog();
            load_DSPTT_TheoMaKH(gView_DSKH.GetRowCellValue(gView_DSKH.FocusedRowHandle, "Mã KH").ToString());
            load_DSKH();
        }

        private void gView_DSKH_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
            else e.Info.DisplayText = "STT";
        }

        private void gView_DSPTT_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
            else e.Info.DisplayText = "STT";
        }

        private void fmDSPhieuThuTien_Load(object sender, EventArgs e)
        {

        }
    }
}