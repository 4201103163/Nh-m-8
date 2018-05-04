using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class KHACHHANG
    {
        string _ma, _ten, _dc, _sdt, _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public string Dc
        {
            get { return _dc; }
            set { _dc = value; }
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
        float _stn;

        public float Stn
        {
            get { return _stn; }
            set { _stn = value; }
        }

        public KHACHHANG(string m, string t, string dc, string sdt, string email, float stn)
        {
            Ma = m;
            Ten = t;
            Dc = dc;
            Sdt = sdt;
            Email = email;
            Stn = stn;
        }

        DB_KHACHHANG dbkh = new DB_KHACHHANG();
        public void Them()
        {
            string sql = "insert into KHACHHANG values (@ma, @ten, @sdt, @email, @dc, @stn)";
            dbkh.Update_KHACHHANG(sql, new KHACHHANG(Ma, Ten, Dc, Sdt, Email, Stn));
        }
        public void Xoa()
        {
            string sql = "delete from KHACHHANG where KH_id = @ma";
            dbkh.Update_KHACHHANG(sql, new KHACHHANG(Ma, Ten, Sdt, Email, Dc, Stn));
        }
        public void Sua()
        {
            string sql = "update KHACHHANG set KH_name = @ten, KH_number = @sdt, Email = @email, KH_address = @dc, KH_scores = @stn where KH_id = @ma";
            dbkh.Update_KHACHHANG(sql, new KHACHHANG(Ma, Ten, Sdt, Email, Dc, Stn));
        }

        public void Sua_STN_Giam()
        {
            string sql = "update KHACHHANG set KH_scores -= @stn where KH_id = @ma";
            dbkh.Update_KHACHHANG(sql, new KHACHHANG(Ma, Ten, Sdt, Email, Dc, Stn));
        }
        public void Sua_STN_Tang()
        {
            string sql = "update KHACHHANG set KH_scores += @stn where KH_id = @ma";
            dbkh.Update_KHACHHANG(sql, new KHACHHANG(Ma, Ten, Sdt, Email, Dc, Stn));
        }
    }
}
