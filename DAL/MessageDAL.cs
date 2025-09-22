using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class MessageDAL
    {
        private string _connStr;

        public MessageDAL(string connStr)
        {
            _connStr = connStr;
        }

        public void SendMessage(int customerId, bool isFromAdmin, string content)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("usp_SendMessage", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                if (isFromAdmin)
                    cmd.Parameters.AddWithValue("@CustomerID", DBNull.Value);
                else
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);

                cmd.Parameters.AddWithValue("@IsFromAdmin", isFromAdmin);
                cmd.Parameters.AddWithValue("@Content", content);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetConversation(int customerId, string role)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("usp_GetConversation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@Role", role);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
