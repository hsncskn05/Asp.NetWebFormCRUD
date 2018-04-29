using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    public class OrdersManagement
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public void AddOrder(Order entity)
        {
            db.Orders.Add(entity);
            db.SaveChanges();
        }
        public Order GetByID(int entityID)
        {
            return db.Orders.Find(entityID);
        }
        public List<Order> ListOrders()
        {

            return db.Orders.ToList();
        }

        public void UpdateOrder(Order entity)
        {
            Order güncellenecekÜrün = GetByID(entity.OrderID);
          
            db.SaveChanges();
        }



        public void RemoveOrder(Order entity)
        {
            db.Orders.Remove(entity);
            db.SaveChanges();
        }
    }
}
