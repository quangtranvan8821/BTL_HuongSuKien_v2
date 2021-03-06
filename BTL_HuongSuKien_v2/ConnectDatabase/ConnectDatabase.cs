using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_HuongSuKien_v2.ConnectDatabase
{
    class ConnectDatabase
    {
        //connect to db
        public SqlConnection getConnect()
        {
            //connect string here
            String strConn = ConfigurationManager.ConnectionStrings["connectAll"].ConnectionString;
            return new SqlConnection(strConn);
        }
        public DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public int  ExcuteNonQuery(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            int soluong =cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
            conn.Close();
            return soluong;
        }
        public String ExcuteScalar(String sql)
        {
            SqlConnection conn = getConnect();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            String kq = cmd.ExecuteScalar().ToString();
            conn.Close();
            return kq;
        }
    }
}
