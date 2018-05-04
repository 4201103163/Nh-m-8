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
    public partial class fmTuSachTamLy : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachTamLy()
        {
            InitializeComponent();
        }

        private void picTL1_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL1.Image;
            txtTL.Text = "- Tên sách: Đắc nhân tâm"
                + Environment.NewLine + "- Tác giả: Lương Trần"
                + Environment.NewLine + "- Nội dung: Đắc Nhân Tâm - Được lòng người, là cuốn sách đưa ra các lời khuyên về cách thức cư xử, ứng xử và giao tiếp với mọi người để đạt được thành công trong cuộc sống. Gần 80 năm kể từ khi ra đời, Đắc Nhân Tâm là cuốn sách gối đầu giường của nhiều thế hệ luôn muốn hoàn thiện chính mình để vươn tới một cuộc sống tốt đẹp và thành công.Đắc Nhân Tâm cụ thể và chi tiết với những chỉ dẫn để dẫn đạo người, để gây thiện cảm và dẫn dắt người khác,... những hướng dẫn ấy, qua thời gian, có thể không còn thích hợp trong cuộc sống hiện đại nhưng nếu người đọc có thể cảm và hiểu được những thông điệp tác giả muốn truyền đạt thì việc áp dụng nó vào cuộc sống trở nên dễ dàng và hiệu quả"
                + Environment.NewLine + "- Giá: 127.000đ";
        }

        private void picTL2_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL2.Image;
            txtTL.Text = "- Tên sách: Không thể bị lừa dối"
                + Environment.NewLine + "- Tác giả: Lương Trần"
                + Environment.NewLine + "- Nội dung: Không thể bị dối lừa bao gồm tám chương, mỗi chương khám phá một khía cạnh của việc nói dối. Các kỹ thuật mới mẻ trong cuốn sách này sẽ giúp bạn xác định được mình có bị lừa dối hay không. Nếu bạn là nạn nhân của một sự lừa dối, chúng sẽ giúp bạn tìm ra chân lý và giành quyền kiểm soát tình hình. Nhiều ví dụ trong cuốn sách này rút ra từ các mối quan hệ cá nhân và các tình huống trong công việc nên rất gần gũi và có giá trị áp dụng thực tiễn cao."
                + Environment.NewLine + "- Giá: 320.000đ";
        }

        private void picTL3_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL3.Image;
            txtTL.Text = "- Tên sách: Khám phá ngôn ngữ tư duy"
                + Environment.NewLine + "- Tác giả: Lương Trần"
                + Environment.NewLine + "- Nội dung: Khám phá ngôn ngữ tư duy là cuốn sách tâm huyết, là sự nỗ lực bền bỉ của tác giả Philip Miller nhằm chia sẻ với mọi người lợi ích thiết thực của NLP trong công việc, trong cách đối nhân xử thế, khám phá bản thân và trải nghiệm cuộc sống. Đây là quyển sách hay, sử dụng ngôn ngữ đơn giản với nhiều hình minh họa sinh động, vui nhộn về NLP (Lập trình ngôn ngữ tư duy)."
                + Environment.NewLine + "- Giá: 73.000";
        }

        private void picTL4_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL4.Image;
            txtTL.Text = "- Tên sách: Thuật đọc nguội"
                + Environment.NewLine + "- Tác giả: Thạch Chân Ngữ"
                + Environment.NewLine + "- Nội dung: Trong cuộc sống hằng ngày, việc xử lý các vấn đề như: quan hệ với khách hàng, ứng xử với sếp và nhân viên, làm thế nào để xây dựng mối quan hệ thân thiết với người khác giới, làm thế nào để phát triển nhiều hơn nữa các mối quan hệ xã hội… khiến chúng ta đau đầu. Mục đích của cuốn sách Thuật đọc nguội là giúp bạn giải quyết những vấn đề kể trên: hướng dẫn bạn cách chung sống hòa thuận với mọi người trong công việc, đời sống.Trong tình huống không có sự chuẩn bị trước, kỹ năng này dùng để nắm bắt tâm lý của đối phương và dự báo sự việc sẽ ra trong tương lai, nhờ đó có thể nhanh chóng được đối phương tin tưởng."
                + Environment.NewLine + "- Giá: 540.000đ";
        }

        private void picTL5_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL5.Image;
            txtTL.Text = "- Tên sách: Những đòn tâm lý trong thuyết phục"
                + Environment.NewLine + "- Tác giả: Thạch Chân Ngữ"
                + Environment.NewLine + "- Nội dung: Trong cuốn sách tuyệt vời này, nhà tâm lý học nổi tiếngThạch Chân Ngữ tiết lộ 6 vũ khí gây ảnh hưởng đầy uy lực: cam kết và nhất quán, khan hiếm, đáp trả, bằng chứng xã hội, uy quyền và thiện cảm. Mỗi loại lại bị chi phối bởi một nguyên tắc tâm lý cơ bản điều khiển hành vi con người và nhờ đó mà tạo nên sức mạnh cho mỗi thủ thuật. Đặc biệt khi được kết hợp với nhau, chúng sẽ tạo ra ảnh hưởng vô cùng lớn. Ở cuối mỗi chương, tác giả sẽ cung cấp các câu chuyện của một số độc giả, để giúp các bạn thấy chúng ta có thể dễ dàng và thường xuyên trở thành nạn nhân của quá trình gây ảnh hưởng trong cuộc sống hàng ngày"
                + Environment.NewLine + "- Giá: 57.000đ";
        }

        private void picTL6_Click(object sender, EventArgs e)
        {
            picTL.Image = picTL6.Image;
            txtTL.Text = "- Tên sách: Trong chớp mắt"
                + Environment.NewLine + "- Tác giả: Thạch Chân Ngữ"
                + Environment.NewLine + "- Nội dung: Trong Chớp Mắt tiết lộ một bí mật: những người quyết định vĩ đại không phải là những người sử dụng hầu hết thông tin, thời gian để cân nhắc kĩ lưỡng, mà lại là những người thành thạo trong nghệ thuật “lát cắt mỏng”, nắm bắt được mọi khía cạnh vấn đề từ một lát cắt mỏng."
                + Environment.NewLine + "- Giá: 56.000đ";
        }

        private void fmTuSachTamLy_Load(object sender, EventArgs e)
        {

        }
    }
}