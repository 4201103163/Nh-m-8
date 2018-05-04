using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_CTPHIEUHD
    {
        public void Update_CTPHIEUHD(string sql, CTPHIEUHD ctphd)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@mactphd", ctphd.Mactphd);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@maphd", ctphd.Maphd);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@mas", ctphd.Mas);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@slb", ctphd.Slb);
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
