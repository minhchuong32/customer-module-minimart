using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class InvoiceDAL
    {
        private readonly string _connStr;
        public InvoiceDAL(string connStr) { _connStr = connStr; }

        public DataTable GetByCustomer(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                string query = "SELECT * FROM dbo.fn_GetInvoicesByCustomer(@CustomerID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable ConvertToPoints(int customerId, int vnd, int point)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Invoice_ConvertToPoints", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@VND", vnd);
                cmd.Parameters.AddWithValue("@POINT", point);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetTransactions(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_LoyaltyHistory_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                cmd.Parameters.AddWithValue("@InvoiceID", DBNull.Value);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
