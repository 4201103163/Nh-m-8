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
    public partial class fmManHinhMoDau : DevExpress.XtraEditors.XtraForm
    {
        public fmManHinhMoDau()
        {
            InitializeComponent();
        }

        private void btnTuSach_Click(object sender, EventArgs e)
        {
            fmTuSach fm = new fmTuSach();
            fm.ShowDialog();
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            fmTacGia_KH fm = new fmTacGia_KH();
            fm.ShowDialog();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {       
            txtND.Text = "Tên chính thức: Công ty TNHH Một Thành Viên Đại học sư Phạm"
                + Environment.NewLine + "Tên tắt: SPB"
                + Environment.NewLine + "Ngày thành lập: 12/5/2012"
                + Environment.NewLine + "Nhà sách Đại học sư phạm là tiền thân của nhà sách Kim Biên, vào khoảng 4/2015 nhà sách Kim Biên được chủ sửa chữa và mở rộng thêm, chính thức đổi tên thành nhà sách Việt Đức. VDB luôn nhấn mạnh và trung thành với chủ trương Sách hay cho mọi người. Việt Đứ đã liên tục xuất bản những đầu sách bán chạy đáp ứng nhu cần căn bản là tìm hiểu và giải trí của đông đảo người yêu sách.Chỉ trong vòng hơn một năm, thương hiệu Việt Đức đã nhanh chóng chinh phục bạn đọc và trở thành chọn lựa ưu tiên với nhiều đối tượng khách hàng cần đến các loại sách từ kinh tế, văn học, tôn giáo đến tâm lý- gia đình hay truyện giải trí tuổi teen.Phong phú, đa thể loại, được chọn lựa, biên tập kỹ càng đã trở thành những đặc trưng của sách Việt Đức và được đọc giả đánh giá cao."
                + Environment.NewLine + "Đến với Phương Nam Book, ai cũng có sách hay để đọc."
                + Environment.NewLine + "Đó là phương châm và cũng là động lực để nhà sách Việt Đức mở rộng danh mục xuất bản của mình và phát triển các dịch vụ mới trong nỗ lực chung nhằm quảng bá văn hóa đọc đến đông đảo người dân. Sách Công nghệ thông tin, sách nấu ăn đang là các sản phẩm nổi bật của nhà sách Việt Đức trên thị trường, bên cạnh dòng sách thiếu nhi là thế mạnh mà chiếm thị phần chi phối nhiều năm nay. Các thể loại khác: văn học (văn học nước ngoài và văn học Việt Nam), truyện trinh thám, tôn giáo, sống đẹp, tâm lý - gia đình luôn được độc giả đón nhận nồng nhiệt nhờ vào nội dung phong phú, hấp dẫn và hình thức đẹp, sang trọng, xứng đáng có một vị trí trang trọng trong các tủ sách gia đình và mọi thư viện cộng đồng. Chủ trương Đến với VDB, ai cũng có sách hay để đọc đã được áp dụng khi Nhà sách Việt Đức triển khai phát triển hệ thống nhà sách riêng của mình. Nhà sách Việt Đức là một không gian đẹp, thân thiện với người mua sách, người đọc sách, nơi có thể tìm được những cuốn sách đa thể loại, mới nhất, hay nhất của các nhà xuất bản, các công ty phát hành sách có uy tín. Nhà sách Việt Đức luôn hiểu rằng sự yêu mến, tin tưởng người đọc làm nên sức mạnh của công ty, và từ đó, những đầu sách hay sẽ ra đời.";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            fmLogin fm = new fmLogin();
            fm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}