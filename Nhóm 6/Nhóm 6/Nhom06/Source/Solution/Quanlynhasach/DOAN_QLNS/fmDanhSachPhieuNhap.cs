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
    public partial class fmDanhSachPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public fmDanhSachPhieuNhap()
        {
            InitializeComponent();
            lblTu.Visible = lblToi.Visible = datiToi.Visible = datiTu.Visible = btTim.Visible = false;
        }
        public void loadds_PN()
        {
            gCtrl_PhieuNS.DataSource = null;
            gView_PhieuNS.Columns.Clear();
            string sql = "select PN.PN_id as [Mã phiếu], PN.PN_date as [Ngày lập phiếu] from PHIEUNHAP PN";
            DBService db = new DBService();
            db.openconn();
            gCtrl_PhieuNS.DataSource = db.getDataReader(sql);
            db.closeconn();
        }

        private void cbTimTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            datiPNS.Text = txtMaPhieu.Text = "";
            if (cbTimTheo.Text == "All")
            {
                lblTu.Visible = lblToi.Visible = datiToi.Visible = datiTu.Visible = btTim.Visible = false;
                loadds_PN();
            }
            else
            {
                lblTu.Visible = lblToi.Visible = datiToi.Visible = datiTu.Visible = btTim.Visible = true;
                gCtrl_PhieuNS.DataSource = gCtrl_DSachPN.DataSource = null;
                gView_PhieuNS.Columns.Clear();
                gView_DSachPN.Columns.Clear();
            }
        }
        public void load_DSPN()
        {
            gCtrl_DSachPN.DataSource = null;
            gView_DSPN.Columns.Clear();
            //DB_PHIEUNHAP db1 = new DB_PHIEUNHAP();
            //gCtrl_DSPN.DataSource = db1.Tim_TheoNgay("24/6/2017");
            ////txtGia.Text = dati.Text;

            string sql = "select PhieuNhap.PN_id as [Mã phiếu nhập], DSSach.Sach_id as [Mã sách], DSSach.Sach_name as [Tên sách], DSSach.Sach_theloai as [Thể loại], DSSach.Sach_tacgia as [Tác giả], CTPhieuNhap.CTPN_number as [Số lượng nhập] from ((dbo.PhieuNhap PhieuNhap inner join dbo.CTPhieuNhap CTPhieuNhap on (CTPhieuNhap.PN_id = PhieuNhap.PN_id)) inner join dbo.DSSach DSSach on (DSSach.Sach_id = CTPhieuNhap.Sach_id)) where PhieuNhap.PN_id = '" + txtMaPhieu.Text + "'";
            DBService db = new DBService();
            db.openconn();
            gCtrl_DSachPN.DataSource = db.getDataReader(sql);
            db.closeconn();
        }

        private void gView_PhieuNS_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            datiPNS.Value = Convert.ToDateTime(gView_PhieuNS.GetRowCellValue(gView_PhieuNS.FocusedRowHandle, "Ngày lập phiếu").ToString());
            txtMaPhieu.Text = gView_PhieuNS.GetRowCellValue(gView_PhieuNS.FocusedRowHandle, "Mã phiếu").ToString();
            load_DSPN();
        }
        public void loadds_PN_TheoKhoangNgay(string d1, string d2)
        {
            gCtrl_PhieuNS.DataSource = null;
            gView_PhieuNS.Columns.Clear();
            string sql = "select PN.PN_id as [Mã phiếu], PN.PN_date as [Ngày lập phiếu] from PHIEUNHAP PN where PN.PN_date >= convert(datetime,'" + d1 + "',103) and PN.PN_date <= convert(datetime,'" + d2 + "',103)";
            DBService db = new DBService();
            db.openconn();
            gCtrl_PhieuNS.DataSource = db.getDataReader(sql);
            db.closeconn();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            loadds_PN_TheoKhoangNgay(datiTu.Text, datiToi.Text);
        }

        private void gCtrl_PhieuNS_DataSourceChanged(object sender, EventArgs e)
        {
            if (gView_PhieuNS.SelectedRowsCount > 0)
            {
                datiPNS.Value = Convert.ToDateTime(gView_PhieuNS.GetRowCellValue(gView_PhieuNS.FocusedRowHandle, "Ngày lập phiếu").ToString());
                txtMaPhieu.Text = gView_PhieuNS.GetRowCellValue(gView_PhieuNS.FocusedRowHandle, "Mã phiếu").ToString();
                load_DSPN();
                btSuaNgayPhieu.Enabled = btSuaSachPhieu.Enabled = btXoaPhieu.Enabled = true;
            }
            else
            {
                btSuaNgayPhieu.Enabled = btSuaSachPhieu.Enabled = btXoaPhieu.Enabled = false;
                gCtrl_DSachPN.DataSource = null;
                gView_DSachPN.Columns.Clear();
            }
        }

        private void btXoaPhieu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gView_DSachPN.RowCount; i++)
            {
                string mapn, mas, sln;
                mapn = gView_DSachPN.GetRowCellValue(i, "Mã phiếu nhập").ToString();
                mas = gView_DSachPN.GetRowCellValue(i, "Mã sách").ToString();
                sln = gView_DSachPN.GetRowCellValue(i, "Số lượng nhập").ToString();
                CTPHIEUNHAP ctpn = new CTPHIEUNHAP(mapn, mas);
                ctpn.Xoa_mapn_mas();
                //PHIEUNHAP pn = new PHIEUNHAP(ctpn.MaCt);
                //pn.Xoa();
                SACH sa = new SACH(mas);
                sa.Sua_SLT(long.Parse(sln));
            }
            PHIEUNHAP pn = new PHIEUNHAP(txtMaPhieu.Text);
            pn.Xoa();
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cbTimTheo.Text == "All") loadds_PN();
            else loadds_PN_TheoKhoangNgay(datiTu.Text, datiToi.Text);
        }

        private void btSuaNgayPhieu_Click(object sender, EventArgs e)
        {
            fmCapNhatNgayLapPhieu nlp = new fmCapNhatNgayLapPhieu(txtMaPhieu.Text, datiPNS.Text);
            nlp.ShowDialog();
            if (cbTimTheo.Text == "All") loadds_PN();
            else loadds_PN_TheoKhoangNgay(datiTu.Text, datiToi.Text);
        }

        private void btSuaSachPhieu_Click(object sender, EventArgs e)
        {
            fmLapPhieuNhap pns = new fmLapPhieuNhap(txtMaPhieu.Text, datiPNS.Text);
            pns.ShowDialog();
            load_DSPN();
        }
    }
}