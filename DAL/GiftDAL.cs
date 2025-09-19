using System.Data;
using System.Data.SqlClient;

namespace MiniMart.DAL
{
    public class GiftDAL
    {
        private readonly string _connStr;
        public GiftDAL(string connStr) { _connStr = connStr; }

        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Gift_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable Redeem(int customerId, int giftId)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Redeem", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@GiftID", giftId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void Insert(string giftName, int pointsRequired, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GiftName", giftName);
                cmd.Parameters.AddWithValue("@PointsRequired", pointsRequired);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(int giftId, string giftName, int pointsRequired, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GiftID", giftId);
                cmd.Parameters.AddWithValue("@GiftName", giftName);
                cmd.Parameters.AddWithValue("@PointsRequired", pointsRequired);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int giftId)
        {
            using (SqlConnection conn = new SqlConnection(_connStr))
            using (SqlCommand cmd = new SqlCommand("dbo.usp_Gift_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GiftID", giftId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
