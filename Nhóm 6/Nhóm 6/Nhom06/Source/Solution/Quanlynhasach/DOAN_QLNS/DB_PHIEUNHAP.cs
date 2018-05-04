using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_PHIEUNHAP
    {
        public void Update_PHIEUNHAP(string sql, PHIEUNHAP pn)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@ma", pn.Ma);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@nn", pn.Ngaynhap);
                cmd.Parameters.Add(pa2);

                cmd.ExecuteNonQuery();
                tran.Commit();//kết thúc transaction
            }
            catch (Exception ex)
            {
                tran.Rollback();//quay lui tới thời điểm beginTran
                throw ex;
            }
            db.closeconn();
        }

        public SqlDataReader Tim_TheoNgay(string d)
        {
            //string sql = "select S.MASACH as [Mã sách], S.TENSACH as [Tên sách], S.THELOAI as [Thể loại], S.TACGIA as [Tác giả], CT.SOLUONGNHAP as [Số lượng nhập] from SACH S join CHITIETPHIEUNHAP CT on S.MASACH = CT.MASACH join PHIEUNHAP PN on CT.MaPHIEUNHAP = PN.MaPHIEUNHAP where PN.NGAYNHAP = convert(datetime,'"+d+"',103)";
            string sql = "select * from PHIEUNHAP where PN_date = convert(datetime,'" + d + "',103)";
            DBService db = new DBService();
            SqlDataReader rd = null;
            db.openconn();
            rd = db.getDataReader(sql);
            //db.closeconn();
            return rd;         
        }
        public SqlDataReader Tim_TheoMa(string ma)
        {
            string sql = "select * from PHIEUNHAP where PN_id = '" + ma + "'";
            DBService db = new DBService();
            db.openconn();
            SqlDataReader rd = db.getDataReader(sql);
            return rd;
        }              
    }
}
