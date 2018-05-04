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
    public partial class fmTuSachKyNang : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachKyNang()
        {
            InitializeComponent();
        }

        private void picKN1_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN1.Image;
            txtKN.Text = "- Tên sách: Tâm hồn cao thượng "
                + Environment.NewLine + "- Tác giả: Edmondo De Amicis"
                + Environment.NewLine + "- Nội dung: Tâm hồn cao thượng đem đến người đọc những câu chuyện nhỏ, diễn ra theo thứ tự thời gian xuyên suốt năm lớp 3 của Enrico, nhưng lại là những vấn đề quan tâm của toàn xã hội. Gia đình Enico Bottini thuộc tầng lớp thượng lưu trong khi nhiều bạn cùng lớp lại xuất thân từ tầng lớp lao động. Đó chính là lý do, dù là trong thế giới của những đứa trẻ, những va đập xã hội vẫn diễn ra liên tục. Bất ngờ là sau những va đập đó, những mảnh vỡ nhặt được lại lóng lánh giá trị sống: lòng yêu nước, sự chân thành và hơn cả, là sự tử tế của mỗi con người."
                + Environment.NewLine + "- Giá: 110.000đ";
        }

        private void picKN2_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN2.Image;
            txtKN.Text = "- Tên sách: Mãi mãi là yêu thương"
                + Environment.NewLine + "- Tác giả: Edmondo De Amicis"
                + Environment.NewLine + "- Nội dung: Yêu thương là cảm xúc thiêng liêng nhất trong cuộc sống của chúng ta. Không một ai có thể sống trên đời mà thiếu tình yêu thương. Cuộc sống của bạn sẽ ý nghĩa hơn nhiều khi bạn biết dành tình thương yêu để làm cho cuộc sống của những người xung quanh và của mình ấm áp, hạnh phúc hơn."
                + Environment.NewLine + "- Giá: 42.000đ";
        }

        private void picKN3_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN3.Image;
            txtKN.Text = "- Tên sách: Ngôn ngữ cơ thể "
                + Environment.NewLine + "- Tác giả: Edmondo De Amicis"
                + Environment.NewLine + "- Nội dung: Ngôn ngữ cơ thể chắc chắn sẽ giúp bạn hiểu rõ vấn đề trong mọi tình huống. Chỉ qua 7 bài học đơn giản, bạn sẽ trở thành một chuyên gia trong việc đọc ý nghĩ của người khác cũng như kiểm soát được mọi cử chỉ của chính mình để đạt hiệu quả mong muốn trong giao tiếp. Đến với sách này, bạn sẽ thấy cả một hệ thống ngôn ngữ mới mẻ đang chờ bạn khám phá: đó là ngôn ngữ không lời - thứ ngôn ngữ giúp bạn gặt hái thành công."
                + Environment.NewLine + "- Giá: 153.000đ";
        }

        private void picKN4_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN4.Image;
            txtKN.Text = "- Tên sách: Đánh Thức Năng Lực Vô Hạn (Tái Bản)"
                + Environment.NewLine + "- Tác giả: Anthony Robbins"
                + Environment.NewLine + "- Nội dung: Đánh Thức Năng Lực Vô Hạn (Unlimited Power) là một quyển sách mang tính “cách mạng” dành cho trí não, từng bước hướng dẫn bạn phát huy tối đa năng lực của bản thân trong khi vẫn cảm thấy thoải mái và an tâm về tài chính, rèn khả năng lãnh đạo và nuôi dưỡng lòng tự tin, đắc nhân tâm và có được sự hợp tác của mọi người."
                + Environment.NewLine + "- Giá: 96.000đ";
        }

        private void picKN5_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN5.Image;
            txtKN.Text = "- Tên sách: Bí quyết tay trắng thành triệu phú"
                + Environment.NewLine + "- Tác giả: Anthony Robbins"
                + Environment.NewLine + "- Nội dung: Đầu tư vào quyển sách này, bạn sẽ hiểu rõ: Nguyên nhân tại sao bạn chưa trở nên giàu có và những cách vượt qua những trở ngại đã ngăn cản bạn đạt được gia tài mơ ước, Cách để quản lý tiền bạc và cắt giảm chi tiêu khoảng 20-35%, Bảy bước để đạt được tự do tài chính để tạo ra dư dả tiền bạc cho suốt cuộc đời bạn..."
                + Environment.NewLine + "- Giá: 125.000đ";
        }

        private void picKN6_Click(object sender, EventArgs e)
        {
            picKN.Image = picKN6.Image;
            txtKN.Text = "- Tên sách: Phải Trái Đúng Sai (Tái Bản 2017)"
                + Environment.NewLine + "- Tác giả: Anthony Robbins"
                + Environment.NewLine + "- Nội dung: Sách bàn về vấn đề đạo đức dưới cái nhìn triết học. Tác giả đưa ra các vụ việc gây tranh cãi về vấn đề đạo đức để mổ xẻ dưới nhiều góc độ, theo quan điểm của các học thuyết triết học khác nhau, mỗi chương trình bày sâu về một học thuyết. Nhờ vậy, tư tưởng của Aristotle, Jeremy Bentham, Immanuel Kant, John Stuart Mill, Robert Nozick, và John Rawl được trình bày với sự rõ ràng và gần gũi, mà theo New York Times là hiếm khi được giải thích dễ hiểu đến như vậy."
                + Environment.NewLine + "- Giá: 140.000đ";
        }
    }
}