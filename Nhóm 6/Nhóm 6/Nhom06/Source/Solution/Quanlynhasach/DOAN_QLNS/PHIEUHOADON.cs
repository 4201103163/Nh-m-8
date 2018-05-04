using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class PHIEUHOADON
    {
        string _maphd, _makh;

        public string Makh
        {
            get { return _makh; }
            set { _makh = value; }
        }

        public string Maphd
        {
            get { return _maphd; }
            set { _maphd = value; }
        }
        DateTime _ngaylaphd;

        public DateTime Ngaylaphd
        {
            get { return _ngaylaphd; }
            set { _ngaylaphd = value; }
        }

        public PHIEUHOADON(string maphd, string makh, DateTime ngaylap)
        {
            Maphd = maphd;
            Makh = makh;
            Ngaylaphd = ngaylap;
        }

        DB_PHIEUHOADON dbphd = new DB_PHIEUHOADON();
        public void Them()
        {
            string sql = "insert into HOADON values (@maphd, @makh,@nlhd)";
            dbphd.Update_PHIEUHOADON(sql, new PHIEUHOADON(Maphd, Makh, Ngaylaphd));
        }
        public void Xoa()
        {
            string sql = "delete form HOADON where HD_id = @maphd";
            dbphd.Update_PHIEUHOADON(sql, new PHIEUHOADON(Maphd, Makh, Ngaylaphd));
        }
        public void Sua()
        {
            string sql = "update HOADON set KH_id = @makh, HD_date = @nlhd where HD_id = @maphd";
            dbphd.Update_PHIEUHOADON(sql, new PHIEUHOADON(Maphd, Makh, Ngaylaphd));
        }
    }
}
