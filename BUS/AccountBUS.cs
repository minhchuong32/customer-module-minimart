using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class AccountBUS
    {
        private readonly AccountDAL dal;
        public AccountBUS(string connStr) { dal = new AccountDAL(connStr); }

        public object Create(int customerId, string username, string password, string memberLevel)
            => dal.Create(customerId, username, password, memberLevel);

        public DataTable GetByCustomer(int customerId) => dal.GetByCustomer(customerId);

        public DataTable GetAll() => dal.GetAll();

        public void Update(int customerId, string username, string password, string memberLevel)
            => dal.Update(customerId, username, password, memberLevel);

        public void Delete(int customerId) => dal.Delete(customerId);
    }
}
