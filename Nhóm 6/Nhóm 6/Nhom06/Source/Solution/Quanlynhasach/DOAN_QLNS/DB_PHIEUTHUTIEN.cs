using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DOAN_QLNS
{
    public class DB_PHIEUTHUTIEN
    {
        public void Update_PHIEUTHUTIEN(string sql, PHIEUTHUTIEN ptt)
        {
            DBService db = new DBService();
            db.openconn();
            SqlCommand cmd = new SqlCommand(sql, db.conn);
            //đánh dấu điểm bắt đầu
            SqlTransaction tran = db.conn.BeginTransaction("ThemLopTransaction");
            cmd.Transaction = tran;
            try
            {
                SqlParameter pa1 = new SqlParameter("@mapt", ptt.Mapt);
                cmd.Parameters.Add(pa1);
                SqlParameter pa2 = new SqlParameter("@stt", ptt.Stt);
                cmd.Parameters.Add(pa2);
                SqlParameter pa3 = new SqlParameter("@ntt", ptt.Ntt);
                cmd.Parameters.Add(pa3);
                SqlParameter pa4 = new SqlParameter("@makh", ptt.Makh);
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
