using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace OrderManagement
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; } = new List<Order>();

        //添加订单:
        public void AddOrder(Order newOrder)
        {
            if (newOrder == null) { throw new Exception("Invalid Order"); }
            if (OrderList.Contains(newOrder)) throw new Exception("The same Order exists");
            OrderList.Add(newOrder);
        }

        //删除订单:
        public void DelOrder(int ID)
        {
            OrderList.RemoveAll(order => order.OrderID == ID);
        }

        //修改订单:
        //重载:修改customer或明细列表
        public void ChangeOrder(Order newOrder)
        {
            if (newOrder == null) { throw new Exception("Invalid Order"); }
            for (int i = 0; i < OrderList.Count; ++i)
            {
                if (OrderList[i].OrderID == newOrder.OrderID)
                {
                    DelOrder(newOrder.OrderID);
                    AddOrder(newOrder);
                    return;
                }
            }
            throw new Exception("The OrderID is not found");
        }

        //查询订单:
        public IOrderedEnumerable<Order> FindOrder(int ID)
        {
            var orders = from order in OrderList where order.OrderID == ID orderby order.OrderTotalPrice select order;
            return orders;
        }
        public IOrderedEnumerable<Order> FindOrder(string goodsName)
        {
            var orders = from order in OrderList 
                         where ((from od in order.OrderDtlList where od.OrderGoods.GoodsName == goodsName select od).Count()!=0)
                         orderby order.OrderTotalPrice
                         select order;
            return orders;
        }
        public IOrderedEnumerable<Order> FindOrder(Customer customer)
        {
            var orders = from order in OrderList where order.OrderCustomer == customer orderby order.OrderTotalPrice select order;
            return orders;
        }
        public IOrderedEnumerable<Order> FindOrder(double price)
        {
            var orders = from order in OrderList where order.OrderTotalPrice == price orderby order.OrderTotalPrice select order;
            return orders;
        }
        //排序功能
        public void Sort()
        {
            OrderList.Sort();
        }
        public void Sort(Comparison<Order> comparison)
        {
            OrderList.Sort(comparison);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder($"The Order(s):\n");
            foreach(Order order in OrderList)
            {
                strBuilder.AppendLine(order.ToString());
            }
            return strBuilder.ToString();
        }

        //序列化
        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs,OrderList);
            }
        }
        public void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                OrderList = (List<Order>)xmlSerializer.Deserialize(fs);
            }
        }
        public void Export(String fileName)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                xs.Serialize(fs, OrderList);
            }
        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!OrderList.Contains(order))
                    {
                        OrderList.Add(order);
                    }
                });
            }
        }
    }
}
