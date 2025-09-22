using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class ExchangeRateDAL
    {
        private readonly string _connStr;
        public ExchangeRateDAL(string connStr)
        {
            _connStr = connStr;
        }

        public string GetRate(string role)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT dbo.fn_GetExchangeRate(@RoleName)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@RoleName", role);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                return result?.ToString() ?? "1:1"; // mặc định 1:1 nếu không có
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public void UpdateRate(string role, string newRate)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("usp_UpdateExchangeRate", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RoleName", role);
                cmd.Parameters.AddWithValue("@Rate", newRate);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
