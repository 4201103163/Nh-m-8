using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_KHACHHANG
    {
        public void Update_KHACHHANG(string sql, KHACHHANG kh)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@ma", kh.Ma);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@ten", kh.Ten);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@dc", kh.Dc);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@sdt", kh.Sdt);
                cmd.Parameters.Add(pa4);
                SqlParameter pa5 = new SqlParameter("@email", kh.Email);
                cmd.Parameters.Add(pa5);
                SqlParameter pa6 = new SqlParameter("@stn", kh.Stn);
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
    }
}
