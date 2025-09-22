using System;
using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class AccountBUS
    {
        private readonly AccountDAL dal;

        public AccountBUS(string connStr)
        {
            dal = new AccountDAL(connStr);
        }

        public object Create(int customerId, string username, string password, string memberLevel)
        {
            return dal.Create(customerId, username, password, memberLevel);
        }

        public DataTable GetByCustomer(int customerId)
        {
            return dal.GetByCustomer(customerId);
        }

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public void Update(int customerId, string username, string password, string memberLevel, string points)
        {
            dal.Update(customerId, username, password, memberLevel, points);
        }

        public void Delete(int customerId)
        {
            dal.Delete(customerId);
        }

        public bool UpdateEmployeeAndAccount(int employeeId, string fullName, string phone,
           string email, string position, string gender, string address,
           DateTime birthDate, DateTime hireDate, string username, string password)
        {
            return dal.UpdateEmployeeAndAccount(employeeId, fullName, phone,
                email, position, gender, address, birthDate, hireDate, username, password);
        }

        public DataRow GetEmployeeAndAccountById(int employeeId)
        {
            return dal.GetEmployeeAndAccountById(employeeId);
        }
    }
}
