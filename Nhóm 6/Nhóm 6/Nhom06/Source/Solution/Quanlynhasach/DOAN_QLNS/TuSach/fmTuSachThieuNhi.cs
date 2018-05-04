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
    public partial class fmTuSachThieuNhi : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachThieuNhi()
        {
            InitializeComponent();
        }

        private void picTN1_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN1.Image;
            txtTN.Text = "- Tên sách: Truyện Tranh Từ Màn Ảnh - Vua Sư Tử"
                + Environment.NewLine + "- Tác giả: Disney"
                + Environment.NewLine + "- Nội dung: Mỗi khung hình - một thước phim. Mỗi câu thoại - một lời truyền cảm hứngMỗi truyện - một ý nghĩa nhân vănTrên bình nguyên châu phi rộng lớn, tất thảy muôn loài đều nằm dưới quyền cai trị của vua sư tử vĩ đại. Đó là vị vua mang trái tim dũng mãnh và kiêu hãnh nhất."
                + Environment.NewLine + "- Giá: 36.000đ";
        }

        private void picTN2_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN2.Image;
            txtTN.Text = "- Tên sách: Truyện Tranh Từ Màn Ảnh - Bí Mật Của Đôi Cánh"
                + Environment.NewLine + "- Tác giả: Disney"
                + Environment.NewLine + "- Nội dung: Đối với Tinker Bell và các tiên cai quản mùa ấm, Khu rừng Mùa đông là lãnh địa cấm đầy bí ẩn. Bởi đã có lệ, tiên xứ ấm và tiên xứ lạnh không được phép gặp nhau, bằng không những đôi cánh mỏng manh của họ sẽ mất đi sức mạnh. Vốn hiếu kỳ, Tink đã lén bay qua biên giới để vào rừng. Ở đây, nàng gặp tiên băng giá Periwinkle và kinh ngạc khi thấy điều lạ thường: cánh của họ lấp lánh khi chạm mặt nhau."
                + Environment.NewLine + "- Giá: 39.000đ";
        }

        private void picTN3_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN3.Image;
            txtTN.Text = "- Tên sách: Truyện Tranh Từ Màn Ảnh - Dũng Sĩ Hercules"
                + Environment.NewLine + "- Tác giả: Disney"
                + Environment.NewLine + "- Nội dung: Mỗi khung hình - một thước phimMỗi câu thoại - một lời truyền cảm hứngMỗi truyện - một ý nghĩa nhân văn. Hãy đến và lắng nghe câu chuyện kể du dương của những nàng thơ trên đỉnh Olympus. Đó là câu chuyện về chàng dũng sĩ Hercules, người anh hùng vĩ ... "
                + Environment.NewLine + "- Giá: 39.000đ";
        }

        private void picTN4_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN4.Image;
            txtTN.Text = "- Tên sách: Bé tập vẽ"
                + Environment.NewLine + "- Tác giả: Hoa Mai"
                + Environment.NewLine + "- Nội dung: Bé thường rất thích vẽ. Tập sách này sẽ giúp bé tự tập vẽ khi ở nhà một mình"
                + Environment.NewLine + "- Giá: 18.000đ";
        }

        private void picTN5_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN5.Image;
            txtTN.Text = "- Tên sách: Truyện Cổ Tích Hoàng Tử Và Công Chúa - Chàng Thợ Săn Và Nàng Công Chúa"
                + Environment.NewLine + "- Tác giả: Hoa Mai"
                + Environment.NewLine + "- Nội dung: Truyện cổ tích đưa trẻ em vào thế giới huyền ảo, bay bổng, trong lành, đẹp đẽ. Đó sẽ là chất xúc tác kích thích trí tưởng tượng, nuôi dưỡng cảm xúc, thẩm mỹ, hướng các em vươn tới những ước mơ, những khát vọng tươi sáng, lành mạnh"
                + Environment.NewLine + "- Giá: 19.000đ";
        }

        private void picTN6_Click(object sender, EventArgs e)
        {
            picTN.Image = picTN6.Image;
            txtTN.Text = "- Tên sách: Em Tìm Hiểu Môi Trường - Mẹ Và Con Một Số Loài Vật"
                + Environment.NewLine + "- Tác giả: Hoa Mai"
                + Environment.NewLine + "- Nội dung: Bé thường đặt câu hỏi 'Trứng gà có từ đâu? Chim cánh cụt đẻ trứng hay đẻ con?...' Những hình ảnh trong tập sách sẽ là lời đáp cho bé."
                + Environment.NewLine + "- Giá: 19.000đ";
        }
    }
}