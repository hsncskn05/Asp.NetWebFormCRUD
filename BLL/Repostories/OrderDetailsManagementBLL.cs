using DAL.Repostories;
using Model_Entity_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repostories
{
    public class OrderDetailsManagementBLL
    {
        OrderDetailsManagement _orderDetailsManagementDAL = new OrderDetailsManagement();

        public void AddOrderDetails(Order_Detail entity)
        {
            _orderDetailsManagementDAL.AddOrderDetails(entity);
        }


        public Order_Detail GetByID(int entityID)
        {
            return _orderDetailsManagementDAL.GetByID(entityID);
        }

        public List<Order_Detail> ListOrder_Details()
        {
            return _orderDetailsManagementDAL.ListOrder_Details();
        }


        public void UpdateOrderDetails(Order_Detail entity)
        {
            _orderDetailsManagementDAL.UpdateOrderDetails(entity);
        }

        public void RemoveOrderDetails(Order_Detail entity)
        {
            _orderDetailsManagementDAL.RemoveOrder_Detail(entity);
        }
   
    }
}
