using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class InvoiceBUS
    {
        private readonly InvoiceDAL dal;
        public InvoiceBUS(string connStr) { dal = new InvoiceDAL(connStr); }

        public DataTable GetByCustomer(int customerId) => dal.GetByCustomer(customerId);

        public DataTable ConvertToPoints(int customerId, int vnd, int point)
            => dal.ConvertToPoints(customerId, vnd, point);

        public DataTable GetTransactions(int customerId) => dal.GetTransactions(customerId);
    }
}
