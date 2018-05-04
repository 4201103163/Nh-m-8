using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class SACH
    {
        string _ma, _ten, _theloai, _tacgia;
        long _slt;
        float _gia;

        public string Tacgia
        {
            get { return _tacgia; }
            set { _tacgia = value; }
        }

        public string Theloai
        {
            get { return _theloai; }
            set { _theloai = value; }
        }

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }

        public long Slt
        {
            get { return _slt; }
            set { _slt = value; }
        }

        public float Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public SACH(string m, string t, string tl, string tg, long slt, float dg)
        {
            Ma = m.Trim();
            Ten = t.Trim();
            Theloai = tl.Trim();
            Tacgia = tg.Trim();
            Slt = slt;
            Gia = dg;
        }
        public SACH(string m)
        {
            Ma = m.Trim();
            Ten = "";
            Theloai = "";
            Tacgia = "";
            Slt = 0;
            Gia = 0;
        }

        DB_SACH db = new DB_SACH();
        public void Them()
        {
            string sql = "INSERT INTO DSSACH(Sach_id, Sach_name, Sach_theloai, Sach_tacgia, Sach_number, Sach_giaban) VALUES(@ma, @ten,@tl, @tg, @slt, @dg)";
            db.Update_SACH(sql, new SACH(Ma, Ten, Theloai, Tacgia, Slt, Gia));
        }
        public void Xoa()
        {
            string sql = "DELETE FROM DSSACH WHERE Sach_id = @ma";
            db.Update_SACH(sql, new SACH(Ma, Ten, Theloai, Tacgia, Slt, Gia));
        }
        public void Sua()
        {
            string sql = "UPDATE DSSACH  SET Sach_id = @ma, Sach_name =  @ten, Sach_theloai = @tl, Sach_tacgia =  @tg, Sach_number = @slt, Sach_giaban = @dg WHERE Sach_id = @ma";
            db.Update_SACH(sql, new SACH(Ma, Ten, Theloai, Tacgia, Slt, Gia));
        }
        public void Sua_SLT(long SLN)
        {
            string sql = "UPDATE DSSACH  SET Sach_number -= @slt WHERE Sach_id = @ma";
            db.Update_SACH(sql, new SACH(Ma, Ten, Theloai, Tacgia, SLN, Gia));
        }
        public void Sua_PNS(long SLN)
        {
            string sql = "UPDATE DSSACH  SET Sach_number += @slt WHERE Sach_id = @ma";
            db.Update_SACH(sql, new SACH(Ma, Ten, Theloai, Tacgia, SLN, Gia));
        }
    }
}
