using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DOAN_QLNS
{
    public partial class fmAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fmAdmin()
        {
            InitializeComponent();
        }
        public fmAdmin(string pq)
        {

            InitializeComponent();
            if (pq != "Admin")
            {
                rbChucNangAdmin.Visible = false;
            }
        }
        private void barMauChu_EditValueChanged(object sender, EventArgs e)
        {
            Color color = (Color)barColor.EditValue;
       
            btnTheLoaiSach.ItemAppearance.Normal.ForeColor = color;
            btnNXB.ItemAppearance.Normal.ForeColor = color;
            btnTacGia.ItemAppearance.Normal.ForeColor = color;
            btnNCC.ItemAppearance.Normal.ForeColor = color;
            btnKhachHang.ItemAppearance.Normal.ForeColor = color;
            btnNhanVien.ItemAppearance.Normal.ForeColor = color;
            btnPhieuNhap.ItemAppearance.Normal.ForeColor = color;
            btnHoaDon.ItemAppearance.Normal.ForeColor = color;
            btnLapPhieuHoaDon.ItemAppearance.Normal.ForeColor = color;
            btnLapPhieuNhap.ItemAppearance.Normal.ForeColor = color;
            btnBaoCaoTon.ItemAppearance.Normal.ForeColor = color;
            btnBaoCaoNo.ItemAppearance.Normal.ForeColor = color;
            btnSachDaMua.ItemAppearance.Normal.ForeColor = color;
            btnDangXuat.ItemAppearance.Normal.ForeColor = color;
            btnThoat.ItemAppearance.Normal.ForeColor = color;
            btnThayDoiQuyDinh.ItemAppearance.Normal.ForeColor = color;
            btnQuanLyNhanVien.ItemAppearance.Normal.ForeColor = color;
            btnDoiMatKhau.ItemAppearance.Normal.ForeColor = color;
            btnDSPN.ItemAppearance.Normal.ForeColor = color;
            btnDSPTT.ItemAppearance.Normal.ForeColor = color;

            rbDanhMuc.Appearance.ForeColor = color;
            rbThongKeBaoCao.Appearance.ForeColor = color;
            rbNghiepVu.Appearance.ForeColor = color;
            rbQuanLy.Appearance.ForeColor = color;
            rbChucNangAdmin.Appearance.ForeColor = color;
            barColor.ItemAppearance.Normal.ForeColor = color;
            barFont.ItemAppearance.Normal.ForeColor = color;
        }
        private void barFontChu_EditValueChanged(object sender, EventArgs e)
        {
            Font font = new Font(barFont.EditValue.ToString(), 9);
 
            font_change_BarBut(btnTheLoaiSach, font);
            font_change_BarBut(btnNXB, font);
            font_change_BarBut(btnTacGia, font);
            font_change_BarBut(btnNCC, font);
            font_change_BarBut(btnKhachHang, font);
            font_change_BarBut(btnNhanVien, font);
            font_change_BarBut(btnPhieuNhap, font);
            font_change_BarBut(btnHoaDon, font);
            font_change_BarBut(btnLapPhieuHoaDon, font);
            font_change_BarBut(btnLapPhieuNhap, font);
            font_change_BarBut(btnBaoCaoNo, font);
            font_change_BarBut(btnBaoCaoTon, font);
            font_change_BarBut(btnSachDaMua, font);
            font_change_BarBut(btnDangXuat, font);
            font_change_BarBut(btnThoat, font);
            font_change_BarBut(btnThayDoiQuyDinh, font);
            font_change_BarBut(btnQuanLyNhanVien, font);
            font_change_BarBut(btnDoiMatKhau, font);
            font_change_BarBut(btnDSPN, font);
            font_change_BarBut(btnDSPTT, font);
            

            rbDanhMuc.Appearance.Font = font;
            rbNghiepVu.Appearance.Font = font;
            rbThongKeBaoCao.Appearance.Font = font;
            rbQuanLy.Appearance.Font = font;
            rbChucNangAdmin.Appearance.Font = font;
            barColor.ItemAppearance.Normal.Font = font;
            barColor.ItemAppearance.Hovered.Font = font;
            barColor.ItemAppearance.Pressed.Font = font;
            barColor.ItemAppearance.Disabled.Font = font;
        }
       
         public void font_change_BarBut(BarButtonItem obj, Font font)
        {
            obj.ItemAppearance.Normal.Font = font;
            obj.ItemAppearance.Hovered.Font = font;
            obj.ItemAppearance.Pressed.Font = font;
            obj.ItemAppearance.Disabled.Font = font;
        }             
         private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
         {
             if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {
                 Application.Exit();
             }                          
         }

         private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
         {
             MessageBox.Show("Thank you for activation!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             this.Hide();
             fmManHinhMoDau pfrm = new fmManHinhMoDau();
             pfrm.ShowDialog();
             pfrm.Dispose();
             this.Show(); 
         }
         

         private void btnThayDoiQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmThayDoiQuyDinh tdqd = new fmThayDoiQuyDinh();
             //if (ExistForm(qlnv)) return;
             //qlnv.MdiParent = this;
             //qlnv.Dock = DockStyle.Fill;
             tdqd.ShowDialog();                        
         }

         private void btnQuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmNhanVien qlnv = new fmNhanVien();
             //if (ExistForm(qlnv)) return;
             //qlnv.MdiParent = this;
             //qlnv.Dock = DockStyle.Fill;
             qlnv.ShowDialog();
         }

         private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmSach_User sach = new fmSach_User();
             //if (ExistForm(qlnv)) return;
             //qlnv.MdiParent = this;
             //qlnv.Dock = DockStyle.Fill;
             sach.ShowDialog();
         }

         private void btnTheLoaiSach_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmTheLoaiSach fm = new fmTheLoaiSach();
             fm.ShowDialog();
         }

         private void btnNXB_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmNhaXuatBan fm = new fmNhaXuatBan();
             fm.ShowDialog();
         }

         private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmNhaCungCap fm = new fmNhaCungCap();
             fm.ShowDialog();
         }

         private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmKhachHang fm = new fmKhachHang();
             fm.ShowDialog();
         }

         private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmNhanVien fm = new fmNhanVien();
             fm.ShowDialog();
         }

         private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmTacGia_User fm = new fmTacGia_User();
             fm.ShowDialog();
         }

         private void btnSachDaMua_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmSachDaMua fm = new fmSachDaMua();
             fm.ShowDialog();
         }

         private void btnLapPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmThongTinPNS fm = new fmThongTinPNS();
             fm.ShowDialog();
         }

         private void btnBaoCaoTon_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmBaoCaoTon fm = new fmBaoCaoTon();
             fm.ShowDialog();
         }

         private void btnBaoCaoNo_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmBaoCaoNo fm = new fmBaoCaoNo();
             fm.ShowDialog();
         }

         private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmChangePassword changepass = new fmChangePassword();            
             changepass.ShowDialog();
         }

         private void btnDSPN_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmDanhSachPhieuNhap fm = new fmDanhSachPhieuNhap();
             fm.ShowDialog();
         }

         private void btnPhieuThuTien_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmPhieuThuTien fm = new fmPhieuThuTien();
             fm.ShowDialog();
         }

         private void btnDSPTT_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmDSPhieuThuTien fm = new fmDSPhieuThuTien();
             fm.ShowDialog();
         }

         private void btnLapPhieuHoaDon_ItemClick(object sender, ItemClickEventArgs e)
         {
             fmThongTinHDBS fm = new fmThongTinHDBS();
             fm.ShowDialog();
         }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }           
    }
}
