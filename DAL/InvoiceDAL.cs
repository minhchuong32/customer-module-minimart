using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices.ComTypes;

namespace MiniMart.DAL
{
    public class InvoiceDAL
    {
        private readonly string _connStr;

        public InvoiceDAL(string connStr)
        {
            _connStr = connStr;
        }

        public DataTable GetByCustomer(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            string query = "SELECT * FROM dbo.fn_GetInvoicesByCustomer(@CustomerID)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public DataTable ConvertToPoints(int customerId, int invoiceId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Invoice_ConvertToPoints", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@InvoiceID", invoiceId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                return dt;
            }
            finally
            {
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public DataTable GetTransactions(int customerId)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                conn = new SqlConnection(_connStr);
                cmd = new SqlCommand("usp_LoyaltyHistory_Get", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                da = new SqlDataAdapter(cmd);

                conn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy lịch sử giao dịch: " + ex.Message, ex);
            }
            finally
            {
                if (da != null) da.Dispose();
                if (cmd != null) cmd.Dispose();
                if (conn != null && conn.State == ConnectionState.Open) conn.Close();
                if (conn != null) conn.Dispose();
            }

            return dt;
        }
    }
}
