using DAL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repostories
{
    public class OrdersManagementBLL
    {
        OrdersManagement _orderManagementDAL = new OrdersManagement();
        public void AddCategory(Order entity)
        {
            _orderManagementDAL.AddOrder(entity);
        }


        public Order GetByID(int entityID)
        {
            return _orderManagementDAL.GetByID(entityID);
        }

        public List<Order> ListOrders()
        {
            return _orderManagementDAL.ListOrders();
        }


        public void UpdateOrder(Order entity)
        {
            _orderManagementDAL.UpdateOrder(entity);
        }

        public void RemoveOrder(Order entity)
        {
            _orderManagementDAL.RemoveOrder(entity);
        }
    }
}
