using System;
using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class CustomerBUS
    {
        private readonly CustomerDAL dal;
        public CustomerBUS(string connStr) { dal = new CustomerDAL(connStr); }

        public DataTable Search(string keyword) => dal.Search(keyword);
        public object Insert(string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
            => dal.Insert(fullName, phone, email, address, gender, birthDate, status);
        public void Update(int id, string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
            => dal.Update(id, fullName, phone, email, address, gender, birthDate, status);
        public void Delete(int id) => dal.Delete(id);
    }
}
