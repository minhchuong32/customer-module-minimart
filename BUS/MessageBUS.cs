using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class MessageBUS
    {
        private MessageDAL dal;

        public MessageBUS(string connStr)
        {
            dal = new MessageDAL(connStr);
        }

        public void Send(int customerId, bool isFromAdmin, string content)
        {
            dal.SendMessage(customerId, isFromAdmin, content);
        }

        public DataTable GetConversation(int customerId, string role)
        {
            return dal.GetConversation(customerId, role);
        }
    }
}
