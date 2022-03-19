using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderManagement
{
    class OrderService
    {
        private List<Order> orderList = new List<Order>();

        //添加订单:
        public void AddOrder(Order newOrder)
        {

            if (newOrder == null) { throw new Exception("Invalid Order"); }
            //判断订单是否重复（已存在）
            bool valid = true;
            foreach(Order order in orderList)
            {
                if (!valid) break;
                valid = !order.Equals(newOrder);
            }
            if (valid) orderList.Add(newOrder);
            else throw new Exception("The same Order exists");
        }

        //删除订单:
        public void DelOrder(int ID)
        {
            for(int i=0;i<orderList.Count;++i)
            {
                if(orderList[i].OrderID==ID)
                {
                    orderList.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("The OrderID is not found");
        }

        //修改订单:
        //重载:修改customer或明细列表
        public void ChangeOrder(int ID, Customer newCustomer)
        {
            for (int i = 0; i < orderList.Count; ++i)
            {
                if (orderList[i].OrderID == ID)
                {
                    orderList[i].OrderCustomer=newCustomer;
                    return;
                }
            }
            throw new Exception("The OrderID is not found");
        }
        public void ChangeOrder(int ID, List<OrderDetails> newOrderDtlList)
        {
            for (int i = 0; i < orderList.Count; ++i)
            {
                if (orderList[i].OrderID == ID)
                {
                    orderList[i].OrderDtlList = newOrderDtlList;
                    return;
                }
            }
            throw new Exception("The OrderID is not found");
        }

        //查询订单:
        public string FindOrder(int ID)
        {
            var orders = from order in orderList where order.OrderID == ID orderby order.OrderTotalPrice select order;
            bool isFound = false;
            StringBuilder strBuilder = new StringBuilder($"The Order with ID:{ID}:\n");
            foreach (Order o in orders)
            {
                isFound = true;
                strBuilder.Append(o.ToString());
            }
            if (isFound) return strBuilder.ToString();
            return $"The Order with ID:{ID} is not found.\n";
        }
        public string FindOrder(string goodsName)
        {
            var orders = from order in orderList 
                         where ((from od in order.OrderDtlList where od.OrderGoods.GoodsName == goodsName select od).Count()!=0)
                         orderby order.OrderTotalPrice
                         select order;
            bool isFound = false;
            StringBuilder strBuilder = new StringBuilder($"The Order(s) that contain the goods {goodsName}:\n");
            foreach(Order o in orders)
            {
                isFound = true;
                strBuilder.AppendLine(o.ToString());
            }
            if(isFound) return strBuilder.ToString();
            return $"The Order that contains the goods:{goodsName} is not found.\n";
        }
        public string FindOrder(Customer customer)
        {
            var orders = from order in orderList where order.OrderCustomer == customer orderby order.OrderTotalPrice select order;
            bool isFound = false;
            StringBuilder strBuilder = new StringBuilder($"The Order of customer:{customer.CustomerName}:\n");
            foreach (Order o in orders)
            {
                isFound = true;
                strBuilder.Append(o.ToString());
            }
            if (isFound) return strBuilder.ToString() + "\n";
            return $"The Order of customer:{customer.CustomerName} is not found.\n";
        }
        public string FindOrder(double price)
        {
            var orders = from order in orderList where order.OrderTotalPrice == price orderby order.OrderTotalPrice select order;
            bool isFound = false;
            StringBuilder strBuilder = new StringBuilder($"The Order of price:{price}:\n");
            foreach (Order o in orders)
            {
                isFound = true;
                strBuilder.Append(o.ToString());
            }
            if (isFound) return strBuilder.ToString() + "\n";
            return $"The Order of price:{price} is not found.\n";
        }
        //排序功能
        public void Sort()
        {
            orderList.Sort();
        }
        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder($"The Order(s):\n");
            foreach(Order order in orderList)
            {
                strBuilder.AppendLine(order.ToString());
            }
            return strBuilder.ToString();
        }
    }
}
