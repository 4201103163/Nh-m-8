using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DOAN_QLNS
{
    public class DBService
    {
        string conString = ConfigurationManager.ConnectionStrings["QLNS"].ConnectionString;

        public SqlConnection conn;
        public void openconn()
        {
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void closeconn()
        {
            conn.Close();
        }
        public SqlDataReader getDataReader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public DataTable getDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }
}
