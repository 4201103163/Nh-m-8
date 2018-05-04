using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_QLNS
{
    public class DB_QUYDINH
    {
        public void Update_THAMSO(string sql, QUYDINH ts)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@qd11", ts.Qd1_1);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@qd12", ts.Qd1_2);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@qd21", ts.Qd2_1);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@qd22", ts.Qd2_2);
                cmd.Parameters.Add(pa4);
                SqlParameter pa5 = new SqlParameter("@qd4", ts.Qd4);
                cmd.Parameters.Add(pa5);

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
