using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class PHIEUNHAP
    {
        string _ma;
        DateTime _ngaynhap;

        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }

        public DateTime Ngaynhap
        {
            get { return _ngaynhap; }
            set { _ngaynhap = value; }
        }

        public PHIEUNHAP(string ma, DateTime ngaynhap)
        {
            Ma = ma;
            Ngaynhap = ngaynhap;
        }

        public PHIEUNHAP(string ma)
        {
            Ma = ma;
            Ngaynhap = DateTime.Now;
        }

        DB_PHIEUNHAP db = new DB_PHIEUNHAP();
        public void Them()
        {
            string sql = "INSERT INTO PHIEUNHAP VALUES(@ma, @nn)";
            db.Update_PHIEUNHAP(sql, new PHIEUNHAP(Ma, Ngaynhap));
        }
        public void Xoa()
        {
            string sql = "DELETE FROM PHIEUNHAP WHERE PN_id = @ma";
            db.Update_PHIEUNHAP(sql, new PHIEUNHAP(Ma, Ngaynhap));

        }
        public void Sua()
        {
            string sql = "UPDATE PHIEUNHAP SET PN_id = @ma, PN_date = @nn";
            db.Update_PHIEUNHAP(sql, new PHIEUNHAP(Ma, Ngaynhap));
        }
    }
}
