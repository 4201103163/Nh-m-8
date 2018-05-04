using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class PHIEUTHUTIEN
    {
        string _mapt, _makh;

        public string Makh
        {
            get { return _makh; }
            set { _makh = value; }
        }

        public string Mapt
        {
            get { return _mapt; }
            set { _mapt = value; }
        }
        float _stt;

        public float Stt
        {
            get { return _stt; }
            set { _stt = value; }
        }
        DateTime _ntt;

        public DateTime Ntt
        {
            get { return _ntt; }
            set { _ntt = value; }
        }

        public PHIEUTHUTIEN(string mapt, float stt, DateTime ntt, string makh)
        {
            Mapt = mapt;
            Stt = stt;
            Ntt = ntt;
            Makh = makh;
        }

        DB_PHIEUTHUTIEN dbptt = new DB_PHIEUTHUTIEN();
        public void Them()
        {
            string sql = "insert into PHIEUTHUTIEN values (@mapt, @stt, @ntt, @makh)";
            dbptt.Update_PHIEUTHUTIEN(sql, new PHIEUTHUTIEN(Mapt, Stt, Ntt, Makh));
        }
        public void Xoa()
        {
            string sql = "delete from PHIEUTHUTIEN where PhieuThuTien_id = @mapt";
            dbptt.Update_PHIEUTHUTIEN(sql, new PHIEUTHUTIEN(Mapt, Stt, Ntt, Makh));
        }
        public void Sua()
        {
            string sql = "update PHIEUTHUTIEN set PhieuThuTien_money = @stt, PhieuThuTien_date = @ntt, KH_id = @makh where PhieuThuTien_id = @mapt";
            dbptt.Update_PHIEUTHUTIEN(sql, new PHIEUTHUTIEN(Mapt, Stt, Ntt, Makh));
        }
    }
}
