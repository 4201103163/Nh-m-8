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
    public partial class fmTuSachNauAn : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachNauAn()
        {
            InitializeComponent();
        }

        private void picNA1_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA1.Image;
            txtNA.Text = "- Tên sách: Việt Nam Miền Ngon (Song Ngữ)"
                + Environment.NewLine + "- Tác giả: Phan Đăng Lưu"
                + Environment.NewLine + "- Nội dung: Ẩm thực Việt ngày nay đã vượt qua khỏi những biên giới và được chào đón ở nhiều nơi trên thế giới. Chúng ta có quyền tự hào về điều đó. Thưởng thức ẩm thực cũng giống như dấn thân vào một cuộc hành trình mà mỗi người đều có cảm nhận riêng. Hy vọng cuốn sách sẽ khiến bạn yêu thêm ẩm thực Việt!"
                + Environment.NewLine + "- Giá: 78.000đ";
        }

        private void picNA2_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA2.Image;
            txtNA.Text = "- Tên sách: Ăn gì cũng dễ thương"
                + Environment.NewLine + "- Tác giả: Phan Đăng Lưu"
                + Environment.NewLine + "- Nội dung: Người ta thường dùng từ dễ thương để nói về những thứ càng nhìn là càng ưng. Và dĩ nhiên ưng cái bụng rồi thì lúc nào mà không thấy vẻ dễ thương? Cuốn sách là những món ăn “dễ thương” mà tác giả gửi lại trong lòng bạn, như một lời nhắn nhủ: Sống là để thương. Mỗi mùa trong năm gửi gắm một niềm thương."
                + Environment.NewLine + "- Giá: 180.000đ";
        }

        private void picNA3_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA3.Image;
            txtNA.Text = "- Tên sách: Bí mật chocolate"
                + Environment.NewLine + "- Tác giả: Phan Đăng Lưu"
                + Environment.NewLine + "- Nội dung: Sự tươi mới luôn là yếu tố quyết định tính hấp dẫn và hương vị thơm ngon của món ăn và chocolate không ngoại lệ. Bạn khó có thể quên được cảm giác tươi nguyên, mềm mại và ngọt dịu nơi đầu lưỡi khi trót thử một viên chocolate nguyên chất.Nếu bạn đang tò mò tìm hiểu về những viên chocolate tươi đầy màu sắc này thì Bí mật Chocolatechắc chắn là một cuốn sách bạn nên có được."
                + Environment.NewLine + "- Giá: 120.000đ";
        }

        private void picNA4_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA4.Image;
            txtNA.Text = "- Tên sách: Bếp thời hiện đại"
                + Environment.NewLine + "- Tác giả: Nguyễn Kim Ngân"
                + Environment.NewLine + "- Nội dung: Bếp thời hiện đại là bộ sách của Chuyên gia ẩm thực Triệu Thị Chơi, giới thiệu những thực đơn gợi ý, món ăn đơn giản, chế biến nhanh nhưng vẫn ngon miệng và đạt hiệu quả cao về mặt dinh dưỡng.Bếp thời hiện đại giúp bạn chuẩn bị bữa ăn hàng ngày của gia đình mà không chiếm quá nhiều thời gian trong cuộc sống bận rộn hiện nay."
                + Environment.NewLine + "- Giá: 90.000đ";
        }

        private void picNA5_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA5.Image;
            txtNA.Text = "- Tên sách: Mẹ nấu ăn ngon tuyệt"
                + Environment.NewLine + "- Tác giả: Nguyễn Kim Ngân"
                + Environment.NewLine + "- Nội dung: Còn gì tuyệt vời hơn khi thấy con yêu hào hứng chờ đón những bữa ăn hàng ngày do chính tay mẹ chuẩn bị. Bộ sách Mẹ nấu ăn ngon tuyệt được biên soạn dành cho các mẹ có con nhỏ trong độ tuổi mẫu giáo. Với những món ăn ngon miệng, đẹp mắt lại cung cấp đầy đủ dưỡng chất cho con, các mẹ sẽ không còn phải tốn nhiều thời gian để suy nghĩ.Hy vọng cuốn sách sẽ là món quà thú vị luôn đồng hành cùng các bà mẹ trẻ hiện đại mỗi khi vào bếp."
                + Environment.NewLine + "- Giá: 23.000đ";
        }

        private void picNA6_Click(object sender, EventArgs e)
        {
            picNA.Image = picNA6.Image;
            txtNA.Text = "- Tên sách: 120 món ăn ngon việt nam"
                + Environment.NewLine + "- Tác giả: Nguyễn Kim Ngân"
                + Environment.NewLine + "- Nội dung: Những món ngon, những bữa ăn đầm ấm là phần không thể thiếu để xây đắp và củng cố hạnh phúc gia đình. Để giúp bạn duy trì những bữa cơm truyền thống đơn giản nhưng ngon miệng cho gia đình mình giữa nhịp sống bận rộn của thời hiện đại, xin giới thiệu đến các bạn cuốn 120 món ăn nogn Việt Nam. Cuốn sách trình bày những công thức nấu ăn đơn giản, dễ làm, hợp khẩu vị của người Việt, giúp bạn tiết kiệm thời gian, có thêm nhiều giây phút hạnh phúc bên những người thân yêu.Hy vọng cuốn sách sẽ là cẩm nang hữu ích cho các bạn!"
                + Environment.NewLine + "- Giá: 130.000đ";
        }
    }
}