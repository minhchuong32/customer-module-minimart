using MiniMart.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMart.BUS
{
    public class StatisticsBUS
    {
        private readonly StatisticsDAL dal;

        public StatisticsBUS(string connStr)
        {
            dal = new StatisticsDAL(connStr);
        }

        public DataSet GetVIPStatistics(int customerId)
        {
            return dal.GetVIPStatistics(customerId);
        }
    }

}
