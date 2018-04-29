using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repostories
{
     public class ProductManagement
    {
        NORTHWNDEntities db = new NORTHWNDEntities();

        public void AddProduct(Product entity)
        {
            db.Products.Add(entity);
            db.SaveChanges();
        }
        public Product GetByID(int entityID)
        {
            return db.Products.Find(entityID);
        }
        public List<Product> ListProducts()
        {

            return db.Products.ToList();
        }

        public void UpdateProduct(Product entity)
        {
            Product güncellenecekÜrün = GetByID(entity.ProductID);
            
            güncellenecekÜrün.ProductName = entity.ProductName;
            
            güncellenecekÜrün.Discontinued = entity.Discontinued;
            db.SaveChanges();
        }
         public void RemoveProductCategoryID(int CategoryID)
        {
            db.Products.RemoveRange(db.Products.Where(p => p.CategoryID == CategoryID));
            db.SaveChanges();
        }


        public void RemoveProduct(Product entity)
        {
            db.Products.Remove(entity);
            db.SaveChanges();
        }

    }
}
