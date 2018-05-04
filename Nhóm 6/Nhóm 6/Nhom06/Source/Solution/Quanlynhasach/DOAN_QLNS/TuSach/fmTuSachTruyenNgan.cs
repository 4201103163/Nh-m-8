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
    public partial class fmTuSachTruyenNgan : DevExpress.XtraEditors.XtraForm
    {
        public fmTuSachTruyenNgan()
        {
            InitializeComponent();
        }

        private void picTNN1_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN1.Image;
            txtTNN.Text = "- Tên sách: Mây vàng"
                + Environment.NewLine + "- Tác giả: Kiều Bích Hậu"
                + Environment.NewLine + "- Nội dung: Tôi đã gặp một kẻ ngẩn ngơ, ngồi trong quán rượu, vừa uống vừa lật một tập sách, mà rồi chẳng thể tìm được cách cắt nghĩa, đành phải bảo rằng nó như là nam châm... Khi yêu, ta mới ngộ ra rằng trước đó mình chưa từng sống.Tập truyện này không kể về một tình yêu cổ tích, hay thần thánh, mà là những phác họa về tình yêu thật.Không phải ai cũng may mắn có!"
               + Environment.NewLine + "- Giá: 23.000đ";
        }

        private void picTNN2_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN2.Image;
            txtTNN.Text = "- Tên sách: Hoa nước"
                + Environment.NewLine + "- Tác giả: Trần Chiến"
                + Environment.NewLine + "- Nội dung: Hoa Nước là tập truyện ngắn của tác giả Trần Chiến. Gồm: Hoa nước,Thị Mầu,Thượng đẳng thần,Tổ sư gàn,Thúy Vân,Ngủ kêu,Trên từng cây số,Táo mèo,Làm sao cứ phải tại sao?,Bay lượn thử nghiệm,Làm đẹp cho đời,Đào nguyên."
                + Environment.NewLine + "- Giá: 35.000đ";
        }

        private void picTNN3_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN3.Image;
            txtTNN.Text = "- Tên sách: Giấc mơ"
                + Environment.NewLine + "- Tác giả: Phạm Phương"
                + Environment.NewLine + "- Nội dung: Tôi đọc xong tập truyện 'Giấc mơ' của Phạm Phương, mất mấy hôm lúc nào cũng vất vưởng tâm trạng của người không rõ mình đang thế nàoĐúng hơn, cô ta tự bạch và tôi bị chạnh lòng. Cái hồi đọc cuốn 'Điên cuồng như Vệ Tuệ' sau khi gấp sách tôi cũng bị cú sốc gần giống như bây giờ. Vệ Tuệ táo tợn, thô thiển và yếu đuối hơn. Cô ta trút hết nỗi niềm vào trang cuối và trang cuối trút hết tội vạ của thế hệ mình cho cha anh. Coi như món nợ được trả. Phạm Phương không thế. Cô không trách ai, khen ai, chê ai, không cảm thấy nợ ai và ai nợ mình."
                + Environment.NewLine + "- Giá: 35.000đ";
        }

        private void picTNN4_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN4.Image;
            txtTNN.Text = "- Tên sách: Phù phiếm truyện"
                + Environment.NewLine + "- Tác giả: Phan Việt"
                + Environment.NewLine + "- Nội dung: Tập truyện của tác giả Phan Việt như đang chảy giữa đôi bờ văn hoá Á - Âu. Sống lâu năm trên đất Mỹ, đang làm việc tại phòng Tổng thanh tra của Sở Dịch vụ Gia đình và Trẻ em Tiểu bang Illinois. Chất nhẹ nhàng, tình cảm của người châu Á pha thêm chút gì đó lành lạnh, khép kín của châu Âu cùng với sự cách tân về mặt bút pháp đã tạo nên một dáng vẻ rất riêng trong truyện của Phan Việt như Nhà lý luận phê bình văn học Huỳnh Như Phương từng nhận định:'Phù phiếm truyện là một trong rất ít tác phẩm độc đáo viết về tuổi hai mươi mà tôi đọc được trong những năm gần đây'."
                + Environment.NewLine + "- Giá: 42.000đ";
        }

        private void picTNN5_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN5.Image;
            txtTNN.Text = "- Tên sách: Bún chả"
                + Environment.NewLine + "- Tác giả: Ninh Kiều"
                + Environment.NewLine + "- Nội dung: Không đao to búa lớn chuyện thế sự cứu nhân độ thế gì. Các truyện trong tập đều kể những cảnh đời loay hoay với việc làm sao để sống hạnh phúc với chồng con, với cháu nội cháu ngoại, với ôsin, với người mới quen mà đã kịp đem đến chút dinh dưỡng cho phần lương tri còn ít lắm ở mỗi con người..."
                + Environment.NewLine + "- Giá: 56.000đ";
        }

        private void picTNN6_Click(object sender, EventArgs e)
        {
            picTNN.Image = picTNN6.Image;
            txtTNN.Text = "- Tên sách: Đời thừa"
                + Environment.NewLine + "- Tác giả: Nam Cao"
                + Environment.NewLine + "- Nội dung: Đời thừa - ấn bản mới phát hành 2016 của Minh Long Book tuyển chọn những truyện ngắn đặc sắc của Nam Cao xoay quanh cuộc sống người trí thức, với những tuyên ngôn để đời của nhà văn Nam Cao về văn chương, nghệ thuật.Qua sáng tác của mình, Nam Cao thể hiện quan điểm nghệ thuật rằng, một tác phẩm văn học phải vượt lên trên tất cả các bờ cõi và giới hạn, phải là một tác phẩm chung cho cả loài người."
                + Environment.NewLine + "- Giá: 34.000đ";
        }
    }
}