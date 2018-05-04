using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_CTPHIEUNHAP
    {
        public void Update_CTPHIEUNHAP(string sql, CTPHIEUNHAP ctpn)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@mact", ctpn.MaCt);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@mapn", ctpn.MaPn);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@mas", ctpn.MaS);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@sln", ctpn.Sln);
                cmd.Parameters.Add(pa4);

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
