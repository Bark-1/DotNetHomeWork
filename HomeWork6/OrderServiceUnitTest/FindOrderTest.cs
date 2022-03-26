using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderServiceUnitTest
{
    [TestClass]
    public class FindOrderTest
    {
        private Customer c1 = new Customer("Bark", "18022483577");
        private Customer c2 = new Customer("Karb", "13924530503");
        private Goods pen = new Goods("Pen", 5);
        private Goods book = new Goods("Book", 10);
        private Goods ruler = new Goods("Ruler", 20);
        private OrderDetails orderDetails1;
        private OrderDetails orderDetails2;
        private OrderDetails orderDetails3;
        //创建订单1
        List<OrderDetails> odList1;
        Order order1;
        //创建订单2
        List<OrderDetails> odList2;
        Order order2;
        //创建OrderService
        public OrderService os;

        [TestInitialize]
        public void ClassIni()
        {
            orderDetails1 = new OrderDetails(pen, 10);
            orderDetails2 = new OrderDetails(pen, 5);
            orderDetails3 = new OrderDetails(book, 10);
            //创建订单1
            odList1 = new List<OrderDetails>() { orderDetails1, orderDetails2, orderDetails3 };
            order1 = new Order(1, c1, odList1);
            //创建订单2
            odList2 = new List<OrderDetails>() { orderDetails1 };
            order2 = new Order(2, c2, odList2);
            os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
        }

        //1. 测试FindOrder(int ID)
        [TestMethod]
        public void TestMethod1()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder(1);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1 });
        }
        [TestMethod]
        public void TestMethod2()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder(5);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { });
        }

        //2. 测试FindOrder(string goodsName)
        [TestMethod]
        public void TestMethod3()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder("Pen");
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1, order2 });
        }
        [TestMethod]
        public void TestMethod4()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder("Book");
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1 });
        }
        [TestMethod]
        public void TestMethod5()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder("");
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { });
        }

        //3. 测试FindOrder(Customer customer)
        [TestMethod]
        public void TestMethod6()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder(c1);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1 });
        }
        [TestMethod]
        public void TestMethod7()
        {
            Order order3 = new Order(3, c1, odList1);
            os.AddOrder(order3);
            IOrderedEnumerable<Order> orders1 = os.FindOrder(c1);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1, order3 });
        }
        [TestMethod]
        public void TestMethod8()
        {
            Customer c = null;
            IOrderedEnumerable<Order> orders1 = os.FindOrder(c);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { });
        }

        //4. 测试FindOrder(double price)
        [TestMethod]
        public void TestMethod9()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder(175.0);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { order1 });
        }
        [TestMethod]
        public void TestMethod10()
        {
            IOrderedEnumerable<Order> orders1 = os.FindOrder(1.0);
            List<Order> list = orders1.ToList<Order>();
            CollectionAssert.Equals(list, new List<Order>() { });
        }
    }
}
