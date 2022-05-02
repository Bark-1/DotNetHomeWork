﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Data.Entity;


namespace OrderManagement
{
    public class OrderService
    {
        public List<Order> OrderList { get; set; } = new List<Order>();

        public OrderService()
        {
            updateOrderList();
        }
        public void updateOrderList()
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Include(o => o.OrderDtlList)
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList.Select(d => d.OrderGoods))
                    .ToList();
                OrderList.Clear();
                query.ForEach(order => OrderList.Add(order));
            }
        }

        //添加订单:
        public void AddOrder(Order newOrder)
        {
            if (newOrder == null) { throw new Exception("Invalid Order"); }
            if (OrderList.Contains(newOrder)) throw new Exception("The same Order exists");
            using (var context = new OrderContext())
            {
                context.Orders.Add(newOrder);
                context.OrderCustomer.Attach(newOrder.OrderCustomer);
                foreach(var od in newOrder.OrderDtlList)
                {
                    context.OrderGoods.Attach(od.OrderGoods);
                }
                context.SaveChanges();
            }
            updateOrderList();
        }

        //删除订单:
        public void DelOrder(int ID)
        {
            using (var context = new OrderContext())
            {
                var delete = context.Orders.FirstOrDefault(o => o.OrderID == ID);
                context.Orders.Remove(delete);
                context.SaveChanges();
            }
            updateOrderList();
        }

        //修改订单:
        public void ChangeOrder(Order newOrder)
        {
            if (newOrder == null) { throw new Exception("Invalid Order"); }
            using (var context = new OrderContext())
            {
                DelOrder(newOrder.OrderID);
                AddOrder(newOrder);
                context.SaveChanges();
            }
            updateOrderList();
        }

        //查询订单:
        public Order FindOrder(int ID)
        {
            using(var context = new OrderContext())
            {
                var query = context.Orders
                    .Include(o => o.OrderDtlList)
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList.Select(d => d.OrderGoods))
                    .FirstOrDefault(o => o.OrderID == ID);
                return query;
            }
            /*var orders = from order in OrderList where order.OrderID == ID orderby order.OrderTotalPrice select order;
            return orders;*/
        }
        public List<Order> FindOrder(string goodsName)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Include(o => o.OrderDtlList)
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList.Select(d => d.OrderGoods))
                    .Where(o => o.OrderDtlList.Any(od=>od.OrderGoods.GoodsName == goodsName))
                    .ToList();
                return query;
            }
            /*var orders = from order in OrderList 
                         where ((from od in order.OrderDtlList where od.OrderGoods.GoodsName == goodsName select od).Count()!=0)
                         orderby order.OrderTotalPrice
                         select order;
            return orders;*/
        }
        public List<Order> FindOrder(Customer customer)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Include(o => o.OrderDtlList)
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList.Select(d => d.OrderGoods))
                    .Where(o => o.OrderCustomer.CustomerName==customer.CustomerName)
                    .ToList();
                return query;
            }
            /*var orders = from order in OrderList where order.OrderCustomer == customer orderby order.OrderTotalPrice select order;
            return orders;*/
        }
        public List<Order> FindOrder(double price)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders
                    .Include(o => o.OrderDtlList)
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList.Select(d => d.OrderGoods))
                    .Where(o => o.OrderTotalPrice==price)
                    .ToList();
                return query;
            }
            /*var orders = from order in OrderList where order.OrderTotalPrice == price orderby order.OrderTotalPrice select order;
            return orders;*/
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
