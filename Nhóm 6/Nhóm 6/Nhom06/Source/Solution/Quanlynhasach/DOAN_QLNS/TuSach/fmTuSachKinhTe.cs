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
    public partial class fmTuSachKinhTe : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachKinhTe()
        {
            InitializeComponent();
        }

        private void picKT1_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT1.Image;
            txtKT.Text = "- Tên sách: Thực chiến cân thị trường"
                + Environment.NewLine + "- Tác giả: Đỗ Thanh Tịnh"
                + Environment.NewLine + "- Thông tin: Nếu Khởi Nghiệp 0 Đồng - Chinh Phục Triệu Đô truyền cảm hứng cho bạn không từ bỏ để đứng lên đi tiếp, thì cuốn Thực chiến cận thị trường giúp bạn học được nhiều chiến lược kinh doanh đường phố có thể ứng dụng ngay và khởi nghiệp hiệu quả."
                + Environment.NewLine + "- Giá: 60.000đ";
        }

        private void picKT2_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT2.Image;
            txtKT.Text = "- Tên sách: Khởi Nghiệp 0 Đồng - Chinh Phục Triệu Đô"
                + Environment.NewLine + "- Tác giả: Đỗ Thanh Tịnh"
                + Environment.NewLine + "- Thông tin: Thất bại đem lại cho tôi nhiều bài học quý giá. Bài học đầu tiên là phải xây dựng được thị trường ngách cho mình. Kế đến là quản trị Doanh Nghiệp phải vững. Và quan trọng hơn, kinh doanh cái gì cũng phải có tâm. Làm ăn gian dối, buôn bán hàng giả hàng nhái trước sau cũng đổ bể"
                + Environment.NewLine + "- Giá: 60.000đ";
        }

        private void picKT3_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT3.Image;
            txtKT.Text = "- Tên sách: 8 Bước Dẫn Đến Thành Công Của Các Nhà Doanh Nghiệp"
                + Environment.NewLine + "- Tác giả: Đỗ Thanh Tịnh"
                + Environment.NewLine + "- Thông tin: Cuốn sách viết về một vài cá nhân đầu tư như thế nào vào cái ngành vừa đặc thù lại vừa biến động; một ngành vừa là người sản xuất vừa là người tiêu dùng. Nó còn viết về quá trình phát tiển của những ngành như thế này."
                + Environment.NewLine + "- Giá: 24.000đ";
        }

        private void picKT4_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT4.Image;
            txtKT.Text = "- Tên sách: Để được trong dụng & Đãi ngộ"
                + Environment.NewLine + "- Tác giả: Brian Tracy"
                + Environment.NewLine + "- Thông tin: Quyển sách thật sự cần thiết cho những ai nuôi tham vọng tiến bước trên con đường công danh, sự nghiệp. Quyển sách sẽ cung cấp cho bạn những phương pháp đơn giản, hiệu quả và đã được kiểm chứng trên thực tế nhằm giúp bạn nâng cao thu nhập và thăng tiến nhanh hơn."
                + Environment.NewLine + "- Giá: 34.000đ";
        }

        private void picKT5_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT5.Image;
            txtKT.Text = "- Tên sách: Thuật tổ chức cuộc họp"
                + Environment.NewLine + "- Tác giả: Brian Tracy"
                + Environment.NewLine + "- Thông tin: Dựa trên kinh nghiệm tư vấn cho các công ty hàng đầu trong suốt nhiều năm, tác giả Brian Tracy đã tự mình rút ra được những điều nên làm trong các cuộc họp – và cả những điều không nên. Trong quyển cẩm nang bỏ túi này, ông đã tiết lộ những ý tưởng đơn giản, xác thực để giúp các cuộc họp trở nên ngắn gọn hơn, hiệu quả hơn và thỏa mãn tất cả những ai tham gia."
                + Environment.NewLine + "- Giá: 47.000đ";
        }

        private void picKT6_Click(object sender, EventArgs e)
        {
            picKT.Image = picKT6.Image;
            txtKT.Text = "- Tên sách: Thuật Thiết Lập Chiến Lược Kinh Doanh"
                + Environment.NewLine + "- Tác giả: Brian Tracy"
                + Environment.NewLine + "- Thông tin: Thuật thiết lập chiến lược kinh doanh sẽ cho phép bạn phát huy sự minh bạch tuyệt đối, để ra các ưu tiên, sắp xếp nguồn lực và đạt thành quả tốt hơn trước rất nhiều. Một kế hoạch chiến lược sẽ kết tinh tương lai của doanh nghiệp và vạch ra hướng đi rõ ràng đến mục tiêu."
                + Environment.NewLine + "- Giá: 47.000đ";
        }
    }
}