using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_SACH
    {
        public void Update_SACH(string sql, SACH sa)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@ma", sa.Ma);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@ten", sa.Ten);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@tl", sa.Theloai);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@tg", sa.Tacgia);
                cmd.Parameters.Add(pa4);
                SqlParameter pa5 = new SqlParameter("@slt", sa.Slt);
                cmd.Parameters.Add(pa5);
                SqlParameter pa6 = new SqlParameter("@dg", sa.Gia);
                cmd.Parameters.Add(pa6);


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
        public void Update_SACH(string sql)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
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

        public SqlDataReader Tim_TheoMa(string ma)
        {
            string sql = "select DSSACH.Sach_id as [Mã sách], DSSACH.Sach_name as [Tên sách], DSSACH.Sach_theloai as [Thể loại], DSSACH.Sach_tacgia as [Tác giả], DSSACH.Sach_number as [Số lượng tồn], DSSACH.Sach_giaban as [Đơn giá] from dbo.DSSACH DSSACH where Sach_id = '" + ma + "'";
            DBService db = new DBService();
            SqlDataReader rd = null;
            db.openconn();
            rd = db.getDataReader(sql);
            //db.closeconn();
            return rd;
        }
        public SqlDataReader Tim_TheoTen(string ten)
        {
            string sql = "select DSSACH.Sach_id as [Mã sách], DSSACH.Sach_name as [Tên sách], DSSACH.Sach_theloai as [Thể loại], DSSACH.Sach_tacgia as [Tác giả], DSSACH.Sach_number as [Số lượng tồn], DSSACH.Sach_giaban as [Đơn giá] from dbo.DSSACH DSSACH where Sach_name = N'" + ten + "'";
            DBService db = new DBService();
            SqlDataReader rd = null;
            db.openconn();
            rd = db.getDataReader(sql);
            //db.closeconn();
            return rd;
        }
    }
}
