using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniMart.DAL;


namespace MiniMart.BUS
{
    class ExchangeRateBUS

    {
        private readonly ExchangeRateDAL dal;

        public ExchangeRateBUS(string connStr)
        {
            dal = new ExchangeRateDAL(connStr);
        }
        public string GetRate(string role)
        {
            return dal.GetRate(role);
        }

        public void UpdateRate(string role, string newRate)
        {
            dal.UpdateRate(role, newRate);
        }

    }
}
