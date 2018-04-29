using DAL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repostories
{
    public  class CategoryManagementBLL
    {
        CategoryManagement _categoryManagementDAL = new CategoryManagement();
        ProductManagement _productManagementDAL = new ProductManagement();
        OrderDetailsManagement _orderDetailsManagementDAL = new OrderDetailsManagement();
        //Create
        public void AddCategory(Category entity)
        {
            _categoryManagementDAL.AddCategory(entity);
        }

        //Read
        public Category GetByID(int entityID)
        {
            return _categoryManagementDAL.GetByID(entityID);
        }
        
        public List<Category> ListCategories()
        {
            return _categoryManagementDAL.ListCategories();
        }
        //Update

        public void UpdateCategory(Category entity)
        {
            _categoryManagementDAL.UpdateCategory(entity);
        }

        public void RemoveCategory(Category entity)
        {
            _orderDetailsManagementDAL.RemoveOrderDetailsCategoryID(entity.CategoryID);
            _productManagementDAL.RemoveProductCategoryID(entity.CategoryID);
            _categoryManagementDAL.RemoveCategory(entity);
        }

    }
}
