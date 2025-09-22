using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class CustomerDAL
    {
        private readonly string _connStr;

        public CustomerDAL(string connStr)
        {
            _connStr = connStr;
        }

        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_Customer_Search(@Keyword) ORDER BY FullName", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Keyword", keyword);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }

        }

        public object Insert(string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Customer_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@BirthDate", birthDate);
            cmd.Parameters.AddWithValue("@Status", status);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public void Update(int id, string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Customer_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", id);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@BirthDate", birthDate);
            cmd.Parameters.AddWithValue("@Status", status);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }


        public bool Delete(int id)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Customer_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", id);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery(); // Số dòng bị ảnh hưởng
                return rows > 0;                  // true nếu có ít nhất 1 dòng bị xóa
            }
            catch (SqlException ex)
            {
                // Nên log lỗi hoặc ném lại Exception cho BUS xử lý
                throw new Exception("Lỗi khi xóa khách hàng: " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }


        public DataRow GetProfile(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_GetCustomerProfile(@CustomerID)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0]; // trả về đúng 1 dòng thông tin
                return null;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }

        public DataTable GetAllCustomers()
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT CustomerID, FullName FROM dbo.vw_Customers ORDER BY CustomerID", conn);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dt);
                return dt;
            }
            finally
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }


    }
}
