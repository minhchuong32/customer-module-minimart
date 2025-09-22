using System;
using System.Data;
using System.Data.SqlClient;
using MiniMart.DAL;
using MiniMart.GUI;

namespace MiniMart.BUS
{
    public class CustomerBUS
    {
        private readonly CustomerDAL dal;
        private readonly AccountDAL dal_acc;

        public CustomerBUS(string connStr)
        {
            dal = new CustomerDAL(connStr);
            dal_acc = new AccountDAL(connStr);
        }

        public DataTable Search(string keyword)
        {
            return dal.Search(keyword);
        }

        public object Insert(string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
        {
            return dal.Insert(fullName, phone, email, address, gender, birthDate, status);
        }

        public void Update(int id, string fullName, string phone, string email, string address, string gender, DateTime birthDate, string status)
        {
            dal.Update(id, fullName, phone, email, address, gender, birthDate, status);
        }

        public bool Delete(int id)
        {
            try
            {
                dal.Delete(id);
                return true; // Return true if deletion is successful
            }
            catch
            {
                return false; // Return false if an exception occurs
            }
        }




        public bool UpdateCustomerAndAccount(int customerId,
                                            string username, string password, string memberLevel, string points,
                                            string fullName, string phone, string email,
                                            string address, string gender, DateTime birthDate, string status)
        {
            try
            {
                // Cập nhật Account
                dal_acc.Update(customerId, username, password, memberLevel, points);

                // Cập nhật Customer
                dal.Update(customerId, fullName, phone, email, address, gender, birthDate, status);

                return true;
            }
            catch (Exception ex)
            {
                // bạn có thể log lỗi ở đây
                return false;
            }
        }

        public DataRow GetCustomerProfile(int customerId)
        {
            return dal.GetProfile(customerId);
        }

        public DataTable GetAllCustomers()
        {
            return dal.GetAllCustomers();
        }

    }
}
