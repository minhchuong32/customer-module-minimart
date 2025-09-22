using System.Data;
using MiniMart.DAL;

namespace MiniMart.BUS
{
    public class GiftBUS
    {
        private readonly GiftDAL dal;

        public GiftBUS(string connStr)
        {
            dal = new GiftDAL(connStr);
        }

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public DataTable Redeem(int customerId, int giftId)
        {
            return dal.Redeem(customerId, giftId);
        }

        public void Insert(string giftName, int pointsRequired, bool isActive)
        {
            dal.Insert(giftName, pointsRequired, isActive);
        }

        public void Update(int giftId, string giftName, int pointsRequired, bool isActive)
        {
            dal.Update(giftId, giftName, pointsRequired, isActive);
        }

        public void Delete(int giftId)
        {
            dal.Delete(giftId);
        }

        public (DataTable, int) GetGiftHistoryByCustomer(int customerId)
        {
            // Có thể thêm validate ở đây nếu muốn
            return dal.GetGiftHistoryByCustomer(customerId);
        }
    }
}
