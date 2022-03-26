using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;

namespace OrderServiceUnitTest
{
    [TestClass]
    public class DelOrderTest
    {
        private Customer c1 = new Customer("Bark", "18022483577");
        private Customer c2 = new Customer("Karb", "13924530503");
        private Goods pen = new Goods("Pen", 5);
        private Goods book = new Goods("Book", 10);
        private Goods ruler = new Goods("Ruler", 20);
        private OrderDetails orderDetails1;
        private OrderDetails orderDetails2;
        private OrderDetails orderDetails3;
        //��������1
        List<OrderDetails> odList1;
        Order order1;
        //��������2
        List<OrderDetails> odList2;
        Order order2;
        //����OrderService
        public OrderService os;

        [TestInitialize]
        public void ClassIni()
        {
            orderDetails1 = new OrderDetails(pen, 10);
            orderDetails2 = new OrderDetails(pen, 5);
            orderDetails3 = new OrderDetails(book, 10);
            //��������1
            odList1 = new List<OrderDetails>() { orderDetails1, orderDetails2, orderDetails3 };
            order1 = new Order(1, c1, odList1);
            //��������2
            odList2 = new List<OrderDetails>() { orderDetails1, orderDetails3 };
            order2 = new Order(2, c2, odList2);
            os = new OrderService();
            os.AddOrder(order1);
            os.AddOrder(order2);
        }

        [TestMethod]
        public void TestMethod1()
        {
            os.DelOrder(2);
            CollectionAssert.Equals(os.OrderList, new List<Order>() { order1 });
        }
        [TestMethod]
        public void TestMethod2()
        {
            os.DelOrder(3);
            CollectionAssert.Equals(os.OrderList, new List<Order>() { order1,order2 });
        }
    }
}
