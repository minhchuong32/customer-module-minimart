using System;
using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class GiftDAL
    {
        private readonly string _connStr;

        public GiftDAL(string connStr)
        {
            _connStr = connStr;
        }

        public DataTable GetAll()
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("SELECT GiftID, GiftName, PointsRequired, IsActive FROM dbo.vw_Gifts ORDER BY PointsRequired, GiftName", conn);
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

        public DataTable Redeem(int customerId, int giftId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Redeem", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@GiftID", giftId);

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

        public void Insert(string giftName, int pointsRequired, bool isActive)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GiftName", giftName);
            cmd.Parameters.AddWithValue("@PointsRequired", pointsRequired);
            cmd.Parameters.AddWithValue("@IsActive", isActive);

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

        public void Update(int giftId, string giftName, int pointsRequired, bool isActive)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GiftID", giftId);
            cmd.Parameters.AddWithValue("@GiftName", giftName);
            cmd.Parameters.AddWithValue("@PointsRequired", pointsRequired);
            cmd.Parameters.AddWithValue("@IsActive", isActive);

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

        public void Delete(int giftId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@GiftID", giftId);

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

        public (DataTable, int) GetGiftHistoryByCustomer(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmdHistory = new SqlCommand("SELECT * FROM dbo.fn_GiftHistoryByCustomer(@CustomerID) ORDER BY RedeemDate DESC", conn);
            cmdHistory.CommandType = CommandType.Text;
            cmdHistory.Parameters.AddWithValue("@CustomerID", customerId);

            SqlCommand cmdPoints = new SqlCommand("SELECT dbo.fn_GetRemainingPoints(@CustomerID)", conn);
            cmdPoints.CommandType = CommandType.Text;
            cmdPoints.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataAdapter da = new SqlDataAdapter(cmdHistory);
            DataTable history = new DataTable();
            int points = 0;

            try
            {
                conn.Open();

                // Lấy lịch sử
                da.Fill(history);

                // Lấy điểm còn lại
                object result = cmdPoints.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    points = Convert.ToInt32(result);

                return (history, points);
            }
            finally
            {
                conn.Close();
                cmdHistory.Dispose();
                cmdPoints.Dispose();
                conn.Dispose();
            }
        }

    }
}
