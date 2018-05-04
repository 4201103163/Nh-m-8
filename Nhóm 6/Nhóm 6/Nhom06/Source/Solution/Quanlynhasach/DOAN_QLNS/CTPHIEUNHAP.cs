using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class CTPHIEUNHAP
    {
        string _maCt, _maPn, _maS;
        int _sln;

        public string MaS
        {
            get { return _maS; }
            set { _maS = value; }
        }

        public string MaPn
        {
            get { return _maPn; }
            set { _maPn = value; }
        }

        public string MaCt
        {
            get { return _maCt; }
            set { _maCt = value; }
        }

        public int Sln
        {
            get { return _sln; }
            set { _sln = value; }
        }

        public CTPHIEUNHAP(string mact, string mapn, string mas, int sln)
        {
            MaCt = mact;
            MaPn = mapn;
            MaS = mas;
            Sln = sln;
        }
        public CTPHIEUNHAP(string mapn, string mas)
        {
            MaCt = "";
            MaPn = mapn;
            MaS = mas;
            Sln = 0;
        }
        public CTPHIEUNHAP(string mact)
        {
            MaCt = mact;
            MaPn = mact;
            MaS = "";
            Sln = 0;
        }

        DB_CTPHIEUNHAP db = new DB_CTPHIEUNHAP();
        public void Them()
        {
            string sql = "INSERT INTO CTPHIEUNHAP VALUES(@mact, @mapn, @mas, @sln)";
            db.Update_CTPHIEUNHAP(sql, new CTPHIEUNHAP(MaCt, MaPn, MaS, Sln));
        }
        public void Xoa()
        {
            string sql = "DELETE FROM CTPHIEUNHAP WHERE CTPN_id = @mact";
            db.Update_CTPHIEUNHAP(sql, new CTPHIEUNHAP(MaCt, MaPn, MaS, Sln));
        }
        public void Sua()
        {
            string sql = "UPDATE CTPHIEUNHAP SET CTPN_id = @mact, PN_id = @mapn, Sach_id = @mas, CTPN_number = @sln WHERE CTPN_id = @mact";
            db.Update_CTPHIEUNHAP(sql, new CTPHIEUNHAP(MaCt, MaPn, MaS, Sln));
        }
        public void Xoa_mapn_mas()
        {
            string sql = "DELETE FROM CTPHIEUNHAP WHERE PN_id = @mapn and Sach_id = @mas";
            db.Update_CTPHIEUNHAP(sql, new CTPHIEUNHAP(MaCt, MaPn, MaS, Sln));
        }
    }
}
