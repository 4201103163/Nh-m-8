using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class CTPHIEUHD
    {
        string _mactphd, _maphd, _mas;

        public string Mas
        {
            get { return _mas; }
            set { _mas = value; }
        }

        public string Maphd
        {
            get { return _maphd; }
            set { _maphd = value; }
        }

        public string Mactphd
        {
            get { return _mactphd; }
            set { _mactphd = value; }
        }
        int _slb;

        public int Slb
        {
            get { return _slb; }
            set { _slb = value; }
        }

        public CTPHIEUHD(string mact, string map, string mas, int slb)
        {
            Mactphd = mact;
            Maphd = map;
            Mas = mas;
            Slb = slb;
        }

        DB_CTPHIEUHD dbctphd = new DB_CTPHIEUHD();
        DB_SACH dbs = new DB_SACH();
        public void Them()
        {
            string sql = "insert into CTHOADON values (@mactphd, @maphd, @mas, @slb)";
            dbctphd.Update_CTPHIEUHD(sql, new CTPHIEUHD(Mactphd, Maphd, Mas, Slb));
            string sqls = "update DSSACH set Sach_number -= " + Slb + " where Sach_id = '" + Mas + "'";
            dbs.Update_SACH(sqls);
        }
        public void Xoa()
        {
            string sql = "delete from CTHOADON where HD_id = @maphd and Sach_id = @mas";
            dbctphd.Update_CTPHIEUHD(sql, new CTPHIEUHD(Mactphd, Maphd, Mas, Slb));
            string sqls = "update DSSACH set Sach_number += " + Slb + " where Sach_id = '" + Mas + "'";
            dbs.Update_SACH(sqls);
        }
        public void Sua()
        {
            string sql = "update CTHOADON set CTPHD_number = @slb where HD_id = @maphd and Sach_id = @mas";
            dbctphd.Update_CTPHIEUHD(sql, new CTPHIEUHD(Mactphd, Maphd, Mas, Slb));
        }
    }
}
