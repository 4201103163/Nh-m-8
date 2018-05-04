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
    public partial class fmNuoiDayCon : DevExpress.XtraEditors.XtraForm
    {
        public fmNuoiDayCon()
        {
            InitializeComponent();
        }

        private void picNC1_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC1.Image;
            txtNC.Text = "- Tên sách: Chăm sóc sức khỏe thai phụ"
                + Environment.NewLine + "- Tác giả: BS. Nguyễn Lân Đính"
                + Environment.NewLine + "- Nội dung: Là một Người Mẹ!Hơn ai hết bạn là người duy nhất hiểu được những cung bậc của cảm xúc trong cuộc sống với bé thân yêu của mình. Ngày đầu tiên biết tin con hiện hữu và tiếp đến là những tháng ngày hạnh phúc, lo ắng luôn hoà quyện từng giây từng phút chuẩn bị bé chào đời. Cuốn sách sẽ mang đến cho bạn những thông tin giúp cho việc chăm sóc thai!"
                + Environment.NewLine + "- Giá: 32.000đ";
        }

        private void picNC2_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC2.Image;
            txtNC.Text = "- Tên sách: Chăm Sóc Và Nuôi Dạy Con Toàn Tập (Bìa Cứng) - Tái bản 09/2012"
                + Environment.NewLine + "- Tác giả: BS. Nguyễn Lân Đính"
                + Environment.NewLine + "- Nội dung: Đây là cuốn cẩm nang đặc biệt với những thông tin, kiến thức, kinh nghiệm khoa học và phương pháp giáo dục giúp các bậc cha mẹ chăm sóc sức khỏe cho bé, điều trị bệnh, hoàn thiện và phát triển các kỹ năng, tư chất, trí thông minh từ khi mới sinh ..."
                + Environment.NewLine + "- Giá: 128.000đ";
        }

        private void picNC3_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC3.Image;
            txtNC.Text = "- Tên sách: Cẩm Nang Chăm Sóc Sức Khỏe Và Luyện Thể Hình Đẹp - Tái bản 06/06/2006"
                + Environment.NewLine + "- Tác giả: BS. Nguyễn Lân Đính"
                + Environment.NewLine + "- Nội dung: Cẩm Nang Chăm Sóc Sức Khoẻ Và Luyện Thể Hình Đẹp Với những kinh nghiệm, kỹ thuật độc đáo và khoa học của Matt Roberts - huấn luyện viên của các ngôi sao - các bạn sẽ nhanh chóng đạt được hiệu quả qua các bài tập thích hợp"
                + Environment.NewLine + "- Giá: 86.000đ";
        }

        private void picNC4_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC4.Image;
            txtNC.Text = "- Tên sách: Nuôi Dạy Con Kiểu Nhật Bản (Dành Cho Ông Bố Bận Rộn)"
                + Environment.NewLine + "- Tác giả: Akehashi Daiji"
                + Environment.NewLine + "- Nội dung: Không ít phụ huynh người Việt quan tâm đến cách dạy con kiểu Nhật bởi đơn giản rằng, ai cũng muốn con mình sở hữu một chỉ số trí tuệ - IQ - thật cao cũng như khả năng nắm bắt mọi kiến thức, tình huống trong cuộc sống một cách nhanh nhẹn và chắc chắn. Nếu có dịp tận mắt chứng kiến môi trường giáo dục trẻ ở lứa tuổi mầm non tại Nhật Bản. Không ai có thể phủ nhận một điều rằng: Người Nhật rất thông minh, nhưng để có được những thành công nổi bật đó cũng phần lớn nhờ cách dạy dỗ của bố mẹ với con cái ngay từ khi còn nhỏ mà nên."
                + Environment.NewLine + "- Giá: 79.000đ";
        }

        private void picNC5_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC5.Image;
            txtNC.Text = "- Tên sách: Nuôi Dạy Con Kiểu Nhật Bản - Tập 2"
                + Environment.NewLine + "- Tác giả: Akehashi Daiji"
                + Environment.NewLine + "- Nội dung: Những điều mà tác giả, bác sĩ tâm lí kiêm chuyên gia tư vấn giáo dục Akehashi Daiji viết trong cuốn sách hết sức giản dị, và tràn đầy tình yêu thương, như một kim chỉ nam dẫn đường cho cha mẹ trong cách ứng xử hàng ngày với con cái, để nuôi dưỡng những đứa trở nên trẻ tự tin và hạnh phúc."
                + Environment.NewLine + "- Giá: 68.000đ";
        }

        private void picNC6_Click(object sender, EventArgs e)
        {
            picNC.Image = picNC6.Image;
            txtNC.Text = "- Tên sách: Nuôi Dạy Con Kiểu Nhật Bản"
                + Environment.NewLine + "- Tác giả: Akehashi Daiji"
                + Environment.NewLine + "- Nội dung: Nuôi dạy con kiểu Nhật Bản được viết bởi Akehashi Daiji - bác sĩ tâm lý, nhà tư vấn giáo dục nổi tiếng của Nhật Bản. Với nhiều gợi ý, bí quyết thiết thực, hữu ích trong việc nuôi dạy trẻ, được trình bày thông qua hình thức những câu chuyện ngắn có hình minh họa sinh động, dễ hiểu, cuốn sách là món quà ý nghĩa dành tặng cho những ông bố bà mẹ đang và sẽ dạy con."
                + Environment.NewLine + "- Giá: 68.000đ";
        }
    }
}