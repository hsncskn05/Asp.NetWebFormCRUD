using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
    public class OrderDetailsManagement
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public void AddOrderDetails(Order_Detail entity)
        {
            db.Order_Details.Add(entity);
            db.SaveChanges();
        }
        public Order_Detail GetByID(int entityID)
        {
            return db.Order_Details.Find(entityID);
        }
        public List<Order_Detail> ListOrder_Details()
        {

            return db.Order_Details.ToList();
        }

        public void UpdateOrderDetails(Order_Detail entity)
        {
            Order_Detail güncellenecekÜrün = GetByID(entity.OrderID);
          
            db.SaveChanges();
        }



        public void RemoveOrder_Detail(Order_Detail entity)
        {
            db.Order_Details.Remove(entity);
            db.SaveChanges();
        }

        public void RemoveOrderDetailsCategoryID(int CategoryID)
        {
            db.Order_Details.RemoveRange(db.Order_Details.Join(db.Products.Where(p=>p.CategoryID==CategoryID),od=>od.ProductID,pr=>pr.ProductID,(od,pr)=>od));
            db.SaveChanges();
        }
        public void RemoveOrderDetailsProductID(int ProductID)
        {
            db.Order_Details.RemoveRange(db.Order_Details.Where(pr => pr.ProductID == ProductID));
            db.SaveChanges();
        }

        public void UpdateOrderDetailsProductID(int ProductID)
        {
           
        }
    }
}
