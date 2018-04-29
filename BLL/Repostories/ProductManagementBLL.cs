using DAL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repostories
{
    public class ProductManagementBLL
    {
        ProductManagement _productManagementDAL = new ProductManagement();
        OrderDetailsManagement _orderDetailsManagementDAL = new OrderDetailsManagement();

        public void AddProduct(Product entity)
        {
            _productManagementDAL.AddProduct(entity);
        }

    
        public Product GetByID(int entityID)
        {
            return _productManagementDAL.GetByID(entityID);
        }

        public List<Product> ListProducts()
        {
            return _productManagementDAL.ListProducts();
        }
       

        public void UpdateProduct(Product entity)
        {
            _productManagementDAL.UpdateProduct(entity);
        }

        public void RemoveProduct(Product entity)
        {
            _orderDetailsManagementDAL.RemoveOrderDetailsProductID(entity.ProductID);
            _productManagementDAL.RemoveProduct(entity);
        }
    }
}
