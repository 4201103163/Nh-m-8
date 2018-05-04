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
    public partial class fmTuSachKinhDi : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachKinhDi()
        {
            InitializeComponent();
        }

        private void picKD1_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD1.Image;
            txtKD.Text = "- Tên sách: Mỗi đêm một câu chuyện kinh dị"
                + Environment.NewLine + "- Tác giả: Vương Vũ Chấn"
                + Environment.NewLine + "- Nội dung: Tuyển tập Mỗi Đêm Một Câu Chuyện Kinh Dị của tác giả Vương Vũ Chấn gồm 20 truyện ngắn quái dị được kể trong 20 đêm, là những câu chuyện kỳ quái rùng rợn, hấp dẫn, lôi cuốn người đọc. Những câu chuyện kỳ quái này không chỉ đơn thuần mang tính kinh dị khiến người đọc “sởn tóc gáy” mà còn trực tiếp đề cập đến những nguy cơ đe dọa đời sống xã hội như tính ác, sự băng hoại đạo đức, những thủ đoạn, lòng tham, thù hận... của con người. Bản chất ma quỷ, sự biến dạng nhân cách của những kẻ đang tồn tại hữu hình còn đáng sợ hơn những hồn ma bóng quế của cõi hư vô."
                + Environment.NewLine + "Giá: 63.000đ";
        }

        private void picKD2_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD2.Image;
            txtKD.Text = "- Tên sách: Đại Nam dị truyện"
                + Environment.NewLine + "- Tác giả: Vương Vũ Chấn"
                + Environment.NewLine + "- Nội dung: Một gã phù thủy đang lập trận thu nạp âm binh giữa bãi chôn người. Phạm Đình Quyết, dòng dõi của một gia đình chín đời làm nghề khâm liệm đã vô tình chứng kiến cảnh tượng kinh dị này.Từ đây, hắn bắt đầu bước chân vào một thế giới chưa từng biết.Hắn dần dần khám phá ra bí mật của gia đình mình. Và thân phận thực sự của hắn, một Lạc Vu Điện Súy của Trấn Quốc Hội, nơi tập hợp những phù thủy cao tay, những nhà huyền thuật xuất sắc đang âm thầm bảo vệ Đông Kinh trước sự tấn công của giáo phái Hàng Long tà đạo từ ngoại bang."
                + Environment.NewLine + "Giá: 76.000đ";
        }

        private void picKD3_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD3.Image;
            txtKD.Text = "- Tên sách: Những chuyện ma kinh hoàng"
                + Environment.NewLine + "- Tác giả: Vương Vũ Chấn"
                + Environment.NewLine + "- Nội dung: Quyển sách nằm trong bộ 4 cuốn những câu chuyện đáng sợ, là tập hợp những truyện dân gian rùng rợn nhất của nhiều nước. Những câu chuyện được truyền miệng qua nhiều thế hệ, độ thật giả vẫn không chứng thực được nhưng có giá trị nhân văn, gieo nhân nào gặt quả nấy, thích hợp cho độc giả yêu thích thể loại truyện kinh dị."
                + Environment.NewLine + "Giá: 21.000đ";
        }

        private void picKD4_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD4.Image;
            txtKD.Text = "- Tên sách: Quán gò đi lên"
                + Environment.NewLine + "- Tác giả: Nguyễn Nhật Ánh"
                + Environment.NewLine + "- Nội dung: Chuyện diễn ra ở quán Đo Đo, quán ăn do tác giả sáng lập để nhớ quê nhà, nơi có chợ Đo Đo - chỗ Quán Gò đi lên ấy. Bởi thế, trong câu truyện tràn ngập những nỗi nhớ, nhớ món ăn, nhớ giọng nói, nhớ thói quen, nhớ kỉ niệm… Dẫu là câu chuyện ngập tràn nỗi nhớ, vẫn nghe trong đó những tiếng cười rất vui."
                + Environment.NewLine + "Giá: 43.000đ";
        }

        private void picKD5_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD5.Image;
            txtKD.Text = "- Tên sách: Cô gái đến từ hôm qua"
                + Environment.NewLine + "- Tác giả: Nguyễn Nhật Ánh"
                + Environment.NewLine + "- Nội dung: Nếu ngày xưa còn bé, Thư luôn tự hào mình là cậu con trai thông minh có quyền bắt nạt và sai khiến các cô bé cùng lứa tuổi thì giờ đây khi lớn lên, anh luôn khổ sở khi thấy mình ngu ngơ và bị con gái “xỏ mũi”. Và điều nghịch lý ấy xem ra càng “trớ trêu’ hơn, khi như một định mệnh, Thư nhận ra Việt An, cô bạn học thông minh thường làm mình bối rối bấy lâu nay chính là Tiểu Li, con bé hàng xóm ngốc nghếch từng hứng chịu những trò nghịch ngợm của mình hồi xưa."
                + Environment.NewLine + "Giá: 31.000đ";
        }

        private void picKD6_Click(object sender, EventArgs e)
        {
            picKD.Image = picKD6.Image;
            txtKD.Text = "- Tên sách: Đảo mộng mơ"
                + Environment.NewLine + "- Tác giả: Nguyễn Nhật Ánh"
                + Environment.NewLine + "- Nội dung: Đảo Mộng mơ là một lát cắt đời sống của những đứa trẻ lên 10 giàu trí tưởng tượng như tất cả mọi đứa trẻ. Chúng mơ mộng, tưởng tượng, và tự làm hiện thực hóa những khao khát của mình.Câu chuyện bắt đầu từ một đống cát, và được diễn ra theo nhân vật tôi - cu Tin.Có một hòn đảo hoang, trên đảo có Chúa đảo, phu nhân Chúa đảo, và một chàng Thứ...Bảy.Hàng ngày vợ chồng Chúa đảo và Thứ Bảy vẫn phải đi học, nhưng sau giờ học là một thế giới khác, của đảo, của biển có cá mập, và rừng có thú dữ.Hấp dẫn, đầy quyến rũ, có cãi vã, có cai trị, có yêu thương, có ẩu đả, và cả...những nụ hôn!"
            + Environment.NewLine + "Giá: 44.000đ";
        }
    }
}