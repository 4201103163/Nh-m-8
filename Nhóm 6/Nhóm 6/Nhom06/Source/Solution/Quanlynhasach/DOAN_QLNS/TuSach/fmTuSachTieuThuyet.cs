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
    public partial class fmTuSachTieuThuyet : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachTieuThuyet()
        {
            InitializeComponent();
        }

        private void picTT1_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT1.Image;
            txtTT.Text = "- Tên sách: Rừng người"
                + Environment.NewLine + "- Tác giả: Đỗ Phấn"
                + Environment.NewLine + "- Nội dung: Rừng Người tái hiện đời sống đô thị Việt Nam đương đại qua lăng kính của người trí thức thị dân. Không gian của tác phẩm cũng chính là không gian ngột ngạt và chật chội chứa đựng đầy rẫy những sự tranh chấp của đô thị - nơi bao bọc đủ kiểu người, dạng người với muôn vàn những kiểu hành nghề để tồn tại và mưu sinh. Nổi bật lên trong thế giới nhân vật của Rừng Người là những gương mặt đàn bà với nhiều cuộc đời khác nhau nhưng cùng chung khát vọng tồn tại và hít thở bầu không khí đô thị."
                + Environment.NewLine + "- Giá: 35.000đ";
        }

        private void picTT2_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT2.Image;
            txtTT.Text = "- Tên sách: Nhà giả kim"
                + Environment.NewLine + "- Tác giả: Paulo Coelko"
                + Environment.NewLine + "- Nội dung: Nhà giả kim như một câu chuyện cổ tích giản dị, nhân ái, giàu chất thơ, thấm đẫm những minh triết huyền bí của phương Đông. Trong lần xuất bản đầu tiên tại Brazil vào năm 1988, sách chỉ bán được 900 bản. Nhưng, với số phận đặc biệt của cuốn sách dành cho toàn nhân loại, vượt ra ngoài biên giới quốc gia, Nhà giả kim đã làm rung động hàng triệu tâm hồn, trở thành một trong những cuốn sách bán chạy nhất mọi thời đại, và có thể làm thay đổi cuộc đời người đọc."
                + Environment.NewLine + "- Giá: 47.000đ";
        }

        private void picTT3_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT3.Image;
            txtTT.Text = "- Tên sách: Mặt phải"
                + Environment.NewLine + "- Tác giả: Trần Hoàng Ngân"
                + Environment.NewLine + "- Nội dung: Chúng ta ai cũng ít nhất một lần gặp phải những tổn thương sâu sắc trong cuộc sống: một mối quan hệ tan vỡ, một người thân yêu qua đời, công việc kinh doanh thất bại, bị mất việc sau nhiều năm phấn đấu, bị tai nạn nghiêm trọng, v.v… Nghịch cảnh là những điều không ai mong muốn gặp phải, có những người hoàn toàn bị khuất phục và đi đến kết cục bi thảm. Ngược lại, có những người không những đã vượt qua nghịch cảnh đó mà thậm chí ngày càng trở nên mạnh mẽ hơn. Những người thành công nhất không đối mặt với điều tồi tệ xảy đến với mình bằng những câu hỏi: “Tại sao lại là tôi?”."
                + Environment.NewLine + "- Giá: 80.000đ";
        }

        private void picTT4_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT4.Image;
            txtTT.Text = "- Tên sách: Nam Cao tiểu thuyết"
                + Environment.NewLine + "- Tác giả: Nam Cao"
                + Environment.NewLine + "- Nội dung: Vượt qua thử thách khắc nghiệt của thời gian , truyện ngắn Nam Cao cho đến ngày nay vẫn chiếm một vị trí vô cùng quan trọng trong lòng người đọc. Người yêu văn chương của Nam Cao nhận ra mỗi vấn đề mà ông đã từng đề cập trong tác phẩm của mình đều là vấn đề bức thiết trong xã hội hiện đại, chúng chưa bao giờ cũ mòn, chúng là những 'tấm gương xê dịch trên quãng đường đời'."
                + Environment.NewLine + "- Giá: 51.000đ";
        }

        private void picTT5_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT5.Image;
            txtTT.Text = "- Tên sách: "
                + Environment.NewLine + "- Tác giả:Nam Cao "
                + Environment.NewLine + "- Nội dung: Tinh thần nhân đạo mà ông gửi gắm qua từng tác phẩm cũng chính là yếu tố giúp các tác phẩm có được sức sống bất diệt. Nhà văn tài năng ấy luôn lấy tình yêu thương con người làm gốc rễ văn chương. Nếu như những nhà văn trước đó chỉ nhắc đến cái nghèo, cái đói vật chất hành hạ con người, thì với Nam Cao, đói nghèo nhân cách lại là điều đáng để băn khoăn, trăn trở.Sáng tạo, sáng tạo và sáng tạo không ngừng nghỉ, Nam Cao đã khẳng định vị thế của mình trong tiến trình phát triển của văn học nước nhà."
                + Environment.NewLine + "- Giá: 49.000đ";
        }

        private void picTT6_Click(object sender, EventArgs e)
        {
            picTT.Image = picTT6.Image;
            txtTT.Text = "- Tên sách: Tiểu thuyết Đàn bà"
                + Environment.NewLine + "- Tác giả: Lý Lan"
                + Environment.NewLine + "- Nội dung: Một trong những nhân vật chính của cuốn sách là người phụ nữ tên Thoa. Chị từng sống trong những khốc liệt của chiến tranh và ở thời hậu chiến, chị vẫn không thoát ra khỏi nỗi ám ảnh của nó. Những kí ức thời chiến tranh  vẫn không buông tha chị, khiến chị luôn phải vật vã, trăn trở với thời hiện tại. Bù lại, với cách viết nhẹ nhàng, không theo kiểu đao to búa lớn, lại pha chút hài hước, nên dù là viết về chiến  tranh nhưng TTĐB của L‎‎ý Lan không làm cho bạn đọc thấy nặng nề, u ám; mà ngược lại còn có những xen gây cười ý nhị.  Vì thế mà đây là cuốn tiểu thuyết khiến bạn khó có thể rời tay khi đã cầm nó lên và đọc cho đến dòng cuối cùng."
                + Environment.NewLine + "- Giá: 31.000đ";
        }
    }
}