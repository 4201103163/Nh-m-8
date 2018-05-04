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
    public partial class fmHoaDonBS : DevExpress.XtraEditors.XtraForm
    {
        public fmHoaDonBS()
        {
            InitializeComponent();           
        }
        string maKH;
        public fmHoaDonBS(string maphd, string tenkh, string _makh, string _nl)
        {
            InitializeComponent();
            load_dsSach();
            datiNgayLap.Text = _nl;
            lblMaHD.Text = maphd;
            txtTenKH.Text = tenkh;
            load_DSHD(lblMaHD.Text);
            maKH = _makh;
        }
        public void load_dsSach()
        {
            gCtrl_DSSach.DataSource = null;
            gView_DSSach.Columns.Clear();
            //gCtrl_DSNV.DataMember = "DSNV";
            //gCtrl_DSNV.DataSource = sqlDS_loadDSNV.Result;
            DBService db = new DBService();
            db.openconn();
            string sql = "select SACH.Sach_id as [Mã sách], SACH.Sach_name as [Tên sách], SACH.Sach_theloai as [Thể loại], SACH.Sach_tacgia as [Tác giả], SACH.Sach_number as [Số lượng tồn], SACH.Sach_giaban as [Đơn giá] from dbo.DSSACH SACH";
            gCtrl_DSSach.DataSource = db.getDataReader(sql);
            db.closeconn();
        }
        public void load_DSHD(string ma)
        {
            gCtrl_HDBS.DataSource = null;
            gView_HDBS.Columns.Clear();
            //gCtrl_DSNV.DataMember = "DSNV";
            //gCtrl_DSNV.DataSource = sqlDS_loadDSNV.Result;
            DBService db = new DBService();
            db.openconn();
            string sql = "select s.Sach_id as [Mã sách], s.Sach_name as [Tên sách], s.Sach_theloai as [Thể loại], ctphd.CTPHD_number as [Số lượng], s.Sach_giaban as [Đơn giá], s.Sach_giaban*ctphd.CTPHD_number as [Thành tiền] from HOADON hd join CTHoaDon ctphd on hd.HD_id = ctphd.HD_id join DSSACH s on ctphd.Sach_id = s.Sach_id where hd.HD_id ='" + ma + "'";
            gCtrl_HDBS.DataSource = db.getDataReader(sql);
            db.closeconn();
        }

        private void btMua_Click(object sender, EventArgs e)
        {
            if (txtSLM.Text.Trim() == "") MessageBox.Show("Chưa nhập số lượng mua!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (int.Parse(gView_DSSach.GetRowCellValue(gView_DSSach.FocusedRowHandle, "Số lượng tồn").ToString()) - int.Parse(txtSLM.Text) < tonsauban)
                {
                    MessageBox.Show("Vi phạm lưu ý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int tangtien = int.Parse(gView_DSSach.GetRowCellValue(gView_DSSach.FocusedRowHandle, "Đơn giá").ToString()) * int.Parse(txtSLM.Text);
                KHACHHANG kh = new KHACHHANG(maKH, "", "", "", "", tangtien);
                kh.Sua_STN_Tang();

                string mactphd, maphd, mas;
                int slb;
                mactphd = DateTime.Now.ToString("ddMMhhmmss");
                maphd = lblMaHD.Text;
                mas = gView_DSSach.GetRowCellValue(gView_DSSach.FocusedRowHandle, "Mã sách").ToString();
                slb = int.Parse(txtSLM.Text);
                CTPHIEUHD ctphd = new CTPHIEUHD(mactphd, maphd, mas, slb);
                ctphd.Them();
                load_DSHD(lblMaHD.Text);
                load_dsSach();
                txtSLM.Text = "";
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string maphd, mas;
            int slb;
            //mactphd = DateTime.Now.ToString("ddMMhhmmss");
            maphd = lblMaHD.Text;
            mas = gView_HDBS.GetRowCellValue(gView_HDBS.FocusedRowHandle, "Mã sách").ToString();
            slb = int.Parse(gView_HDBS.GetRowCellValue(gView_HDBS.FocusedRowHandle, "Số lượng").ToString());
            CTPHIEUHD ctphd = new CTPHIEUHD("", maphd, mas, slb);
            ctphd.Xoa();
            load_DSHD(lblMaHD.Text);
            load_dsSach();
        }

        private void gCtrl_HDBS_DataSourceChanged(object sender, EventArgs e)
        {
            if (gView_HDBS.SelectedRowsCount > 0) btXoa.Enabled = true;
            else btXoa.Enabled = false;
        }

        int tonsauban;
        private void fmHoaDonBS_Load(object sender, EventArgs e)
        {
            string sql = "select * from QUYDINH";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            rd.Read();
            tonsauban = rd.GetInt32(3);
            db.closeconn();

            lblText.Text += tonsauban.ToString();
        }

        private void txtSLM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            string t = txtTenKH.Text;
            string n = datiNgayLap.Value.ToString("dd-MM-yyyy");
            frm_Report_HDBS hd = new frm_Report_HDBS(t, n);
            hd.ShowDialog();
        }

        private void gView_HDBS_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
            else e.Info.DisplayText = "STT";
        }

        private void gView_DSSach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0) e.Info.DisplayText = (e.RowHandle + 1).ToString();
            else e.Info.DisplayText = "STT";
        }
    }
}