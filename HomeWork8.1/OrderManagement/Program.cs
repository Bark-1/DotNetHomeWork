using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建客户和商品
            Customer c1 = new Customer("Bark", "18022483577"); 
            Customer c2 = new Customer("Karb", "13924530503");
            Goods pen = new Goods("Pen", 5);
            Goods book = new Goods("Book", 10);
            Goods ruler = new Goods("Ruler", 20);
            //创建订单明细
            OrderDetails orderDetails1 = new OrderDetails(pen, 10);
            OrderDetails orderDetails2 = new OrderDetails(pen, 5);
            OrderDetails orderDetails3= new OrderDetails(book, 10);
            OrderDetails orderDetails4 = new OrderDetails(ruler, 10);
            //创建订单1
            //订单1有3个明细
            //10笔，5笔，10本|Bark客户|175元
            List<OrderDetails> odList1 = new List<OrderDetails>() { orderDetails1, orderDetails2, orderDetails3 };
            Order order1 = new Order(1, c1, odList1);
            //创建订单2
            //订单2有3个明细，第三个明细使用Order的AddOrderDetails()
            //10笔，10本，10尺|Karb客户|350元-----并将在修改订单测试中修改明细成odList3
            List<OrderDetails> odList2 = new List<OrderDetails>() { orderDetails1,orderDetails3};
            Order order2 = new Order(2, c2, odList2);
            order2.AddOrderDetails(orderDetails4);
            //创建订单3
            //订单3有2个明细，并尝试用AddOrderDetails()加入相同的明细，会报异常
            //10本，10尺|Bark客户|300元
            List<OrderDetails> odList3 = new List<OrderDetails>() { orderDetails3,orderDetails4};
            Order order3 = new Order(3, c1, odList3);
            try
            {
                Console.WriteLine("Try add OrderDetails5 to Order3");
                OrderDetails orderDetails5 = new OrderDetails(ruler, 10); //明细5和明细4的商品和数量一致，Equals()认为相同
                order2.AddOrderDetails(orderDetails5);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("\nTest OrderService:");
            //测试OrserService
            //创建os对象
            OrderService os = new OrderService();
            //1.测试添加订单
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            try //尝试添加相同的order，会报错
            {
                Console.WriteLine("\nTry add Order4 to orderService");
                Order order4 = new Order(3, c2, odList3); //order4和order3的ID一样，Equals()认为相同
                os.AddOrder(order4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //2.测试删除订单
            os.DelOrder(3);
            try //测试删除不存在的订单
            {
                Console.WriteLine("\nTry delete");
                os.DelOrder(4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //3.测试修改订单
            Order order7 = new Order(2,c2,odList3);
            os.ChangeOrder(order7); //修改后：10本，10尺|Karb客户|300元
            try //尝试修改不存在订单
            {
                Console.WriteLine("\nTry change");
                os.ChangeOrder(order3);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
            //4.测试查询订单
            //现在还剩订单1和2
            //4.1按ID查找
            Console.WriteLine("The Order with ID:1");
            IOrderedEnumerable<Order> orders1 = os.FindOrder(1);
            foreach(Order order in orders1)
            {
                Console.WriteLine(order.ToString());
            }
            //4.2按商品查找
            Console.WriteLine("The Order(s) that contain the goods Book:");
            IOrderedEnumerable<Order> orders2 = os.FindOrder("Book");
            foreach (Order order in orders2)
            {
                Console.WriteLine(order.ToString());
            }
            //4.3按客户查找
            Console.WriteLine("The Order(s) of c1:");
            IOrderedEnumerable<Order> orders3 = os.FindOrder(c1);
            foreach (Order order in orders3)
            {
                Console.WriteLine(order.ToString());
            }
            //4.4按价格查找
            Console.WriteLine("The Order(s) that price:175.0:");
            IOrderedEnumerable<Order> orders4 = os.FindOrder(175.0);
            foreach (Order order in orders4)
            {
                Console.WriteLine(order.ToString());
            }

            //5.排序测试
            //5.1默认排序方式测试：按ID
            Order order6 = new Order(0, c1, odList2);
            os.AddOrder(order6);
            Console.WriteLine("Before sort:\n"+os.ToString());
            os.Sort();
            Console.WriteLine("After sort:\n" + os.ToString());
            //5.2按价格排序
            os.Sort((o1,o2)=>o1.OrderTotalPrice.CompareTo(o2.OrderTotalPrice));
            Console.WriteLine("After sort by price:\n" + os.ToString());

            //6.序列化测试
            Console.WriteLine("-------------------\n序列化测试");
            os.Export();
            os.DelOrder(1);
            os.Import();
            Console.WriteLine(os.ToString());
        }
    }
}
