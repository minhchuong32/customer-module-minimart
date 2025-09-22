using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class AccountDAL
    {
        private readonly string _connStr;

        public AccountDAL(string connStr)
        {
            _connStr = connStr;
        }

        public object Create(int customerId, string username, string password, string memberLevel)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Account_Create", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@MemberLevel", memberLevel);

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

        public DataTable GetByCustomer(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_Account_GetByCustomer(@CustomerID)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

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

        public DataTable GetAll()
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.vw_AccountAll ORDER BY FullName", conn);
            cmd.CommandType = CommandType.Text;

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

        public void Update(int customerId, string username, string password, string memberLevel, string points)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Account_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@MemberLevel", memberLevel);
            cmd.Parameters.AddWithValue("@Points", points);

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


        public void Delete(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Account_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);

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

        public bool UpdateEmployeeAndAccount(int employeeId, string fullName, string phone,
          string email, string position, string gender, string address,
          DateTime birthDate, DateTime hireDate, string username, string password)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("usp_UpdateEmployeeAndAccount", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);
            cmd.Parameters.AddWithValue("@FullName", fullName);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Position", position);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Address", address);
            cmd.Parameters.AddWithValue("@BirthDate", birthDate);
            cmd.Parameters.AddWithValue("@HireDate", hireDate);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            try
            {
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật Employee & Account: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow GetEmployeeAndAccountById(int employeeId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.fn_GetEmployeeAndAccountById(@EmployeeID)", conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                    return dt.Rows[0];  // trả về đúng 1 dòng Employee + Account
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy Employee & Account: " + ex.Message, ex);
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
