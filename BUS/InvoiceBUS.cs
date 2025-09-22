using System;
using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class InvoiceBUS
    {
        private readonly InvoiceDAL dal;

        public InvoiceBUS(string connStr)
        {
            dal = new InvoiceDAL(connStr);
        }

        public DataTable GetByCustomer(int customerId)
        {
            return dal.GetByCustomer(customerId);
        }

        public DataTable ConvertToPoints(int customerId, int invoiceId)
        {
            return dal.ConvertToPoints(customerId, invoiceId);
        }

        public DataTable GetTransactions(int customerId)
        {
            return dal.GetTransactions(customerId);
        }
    }
}
