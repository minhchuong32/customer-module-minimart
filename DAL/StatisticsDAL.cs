using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.DAL
{
    public class StatisticsDAL
    {
        private readonly string _connStr;
        public StatisticsDAL(string connStr)
        {
            _connStr = connStr;
        }

        public DataSet GetVIPStatistics(int customerId)
        {
            SqlConnection conn = new SqlConnection(_connStr);
            SqlCommand cmd = new SqlCommand("usp_VIP_Statistics", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds; // ds.Tables[0] = tổng quan
        }
    }

}
