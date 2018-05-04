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
    public partial class fmCapNhapPhieuNhapSach : DevExpress.XtraEditors.XtraForm
    {
        public fmCapNhapPhieuNhapSach()
        {
            InitializeComponent();
        }
         string mapn, mas_old, sln_old;
         public fmCapNhapPhieuNhapSach(string _mapn, string mas, string t, string tl, string tg, string sln)
        {
            InitializeComponent();
            sln_old = sln;
            mapn = _mapn;
            mas_old = mas;
            btEditMa.Text = mas;
            btEditTen.Text = t;
            txtTL.Text = tl;
            txtTG.Text = tg;
           // txtGia.Text = gia;
           // txtSLT.Text = slt;
            txtSLN.Text = sln;
        }
        public bool timSach_Ma(string ma)
        {
            DB_SACH db = new DB_SACH();
            SqlDataReader rd = db.Tim_TheoMa(ma);
            if (rd.HasRows)
            {
                rd.Read();
                if (ma.Trim() == rd.GetString(0).Trim())
                {
                    //btEditMa.Text = rd.GetString(0);
                    btEditTen.Text = rd.GetString(1);
                    txtTL.Text = rd.GetString(2);
                    txtTG.Text = rd.GetString(3);
                    //txtSLT.Text = rd.GetInt32(4).ToString();
                   // txtGia.Text = rd.GetDouble(5).ToString();
                    return true;
                }
                // else MessageBox.Show("Không tìm thấy mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // else MessageBox.Show("Không tìm thấy mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        public bool timSach_Ten(string ten)
        {
            DB_SACH db = new DB_SACH();
            SqlDataReader rd = db.Tim_TheoTen(ten.Trim());
            if (rd.HasRows)
            {
                rd.Read();
                if (ten.Trim() == rd.GetString(1).Trim())
                {
                    btEditMa.Text = rd.GetString(0);
                    // btEditTen.Text = rd.GetString(1);
                    txtTL.Text = rd.GetString(2);
                    txtTG.Text = rd.GetString(3);
                    //txtSLT.Text = rd.GetInt32(4).ToString();
                   // txtGia.Text = rd.GetDouble(5).ToString();
                    return true;
                }
                //else MessageBox.Show("Không tìm thấy tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else MessageBox.Show("Không tìm thấy tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (timSach_Ma(btEditMa.Text.Trim()) == true && timSach_Ten(btEditTen.Text.Trim()) == true) // nếu sách đã có
            {
                if (txtSLN.Text != "")
                {
                    CTPHIEUNHAP xoa_ctpn = new CTPHIEUNHAP(mapn, mas_old);
                    xoa_ctpn.Xoa_mapn_mas();
                    SACH xoasa = new SACH(mas_old);
                    xoasa.Sua_SLT(long.Parse(sln_old));

                    //long newSLT = long.Parse(txtSLT.Text) + long.Parse(txtSLN.Text);
                    SACH sa = new SACH(btEditMa.Text.Trim());
                    sa.Sua_PNS(long.Parse(txtSLN.Text.Trim()));
                    //string mapn = DateTime.Now.ToString("ddMMhhmmss");
                    //PHIEUNHAP pn = new PHIEUNHAP(mapn, Convert.ToDateTime(dati.Text));
                    //pn.Them();

                    CTPHIEUNHAP ctpn = new CTPHIEUNHAP(DateTime.Now.ToString("ddMMhhmmss"), mapn, btEditMa.Text.Trim(), int.Parse(txtSLN.Text.Trim()));
                    ctpn.Them();
                    // load_DSPN();
                }
                else MessageBox.Show("Số lượng nhập của sách chưa có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // nếu sách chưa có
            {
                if (txtSLN.Text != "")
                {
                    DialogResult dr = MessageBox.Show("Sách này hiện chưa có trong nhà sách, bạn có muốn thêm sách mới vào danh sách sách?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr != DialogResult.Yes) return;
                    CTPHIEUNHAP xoa_ctpn = new CTPHIEUNHAP(mapn, mas_old);
                    xoa_ctpn.Xoa_mapn_mas();
                    SACH xoasa = new SACH(mas_old);
                    xoasa.Sua_SLT(long.Parse(sln_old));

                    // if (txtGia.Text.Trim() == "") txtGia.Text = "0";
                    SACH sa = new SACH(btEditMa.Text.Trim(), btEditTen.Text.Trim(), txtTL.Text.Trim(), txtTG.Text.Trim(), long.Parse(txtSLN.Text.Trim()), 0);
                    sa.Them();
                 
                    CTPHIEUNHAP ctpn = new CTPHIEUNHAP(DateTime.Now.ToString("ddMMhhmmss"), mapn, btEditMa.Text, int.Parse(txtSLN.Text.Trim()));
                    ctpn.Them();
                    //load_DSPN();
                }
                else MessageBox.Show("Số lượng nhập của sách chưa có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Cập nhật thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btEditMa_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!timSach_Ma(btEditMa.Text.Trim())) MessageBox.Show("Không tìm thấy mã sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btEditTen_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!timSach_Ten(btEditTen.Text.Trim())) MessageBox.Show("Không tìm thấy tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}