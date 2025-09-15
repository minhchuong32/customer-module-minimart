using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart
{
    public static class Db
    {

        // Chuỗi kết nối (hard-code demo)
        private const string CsNormal = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;User ID=normal_login;Password=Normal@123;TrustServerCertificate=True";
        private const string CsVip = @"Data Source=MINH-CHUONG;Initial Catalog=MiniMartDB;User ID=vip_login;Password=Vip@123;TrustServerCertificate=True";

        public static DataTable ExecDataTable(string proc, Action<SqlParameterCollection> addParams = null, bool useVip = false)
        {
            DataTable dt = new DataTable();
            string cs = useVip ? CsVip : CsNormal;

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(proc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (addParams != null)
                    {
                        addParams(cmd.Parameters);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static object ExecScalar(string proc, Action<SqlParameterCollection> addParams = null, bool useVip = false)
        {
            object result = null;
            string cs = useVip ? CsVip : CsNormal;

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(proc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (addParams != null)
                    {
                        addParams(cmd.Parameters);
                    }

                    con.Open();
                    result = cmd.ExecuteScalar();
                }
            }
            return result;
        }

        public static int ExecNonQuery(string proc, Action<SqlParameterCollection> addParams = null, bool useVip = false)
        {
            int rows = 0;
            string cs = useVip ? CsVip : CsNormal;

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(proc, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (addParams != null)
                    {
                        addParams(cmd.Parameters);
                    }

                    con.Open();
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return rows;
        }
    }
}
