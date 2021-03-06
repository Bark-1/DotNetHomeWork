using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManagement;
using System;
using System.Collections.Generic;

namespace OrderServiceUnitTest
{
    [TestClass]
    public class SortTest
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
        //创建订单3
        List<OrderDetails> odList3;
        Order order3;
        //创建OrderService
        public OrderService os;

        [TestInitialize]
        public void ClassIni()
        {
            orderDetails1 = new OrderDetails(pen, 10);
            orderDetails2 = new OrderDetails(pen, 5);
            orderDetails3 = new OrderDetails(book, 10);
            //创建订单1
            odList1 = new List<OrderDetails>() { orderDetails1, orderDetails2 };//75
            order1 = new Order(1, c1, odList1);
            //创建订单2
            odList2 = new List<OrderDetails>() { orderDetails1, orderDetails2, orderDetails3 };//175
            order2 = new Order(2, c2, odList2);
            //创建订单2
            odList3 = new List<OrderDetails>() { orderDetails1, orderDetails3 };//150
            order3 = new Order(3, c2, odList3);
            os = new OrderService();
        }

        [TestMethod]
        public void TestMethod1()
        {
            os.AddOrder(order3);
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.Sort();
            List<Order> result = new List<Order>() { order1, order2, order3 };
            bool isTrue = true;
            for(int i=0;i<3;i++)
            {
                if(os.OrderList[i] != result[i])
                {
                    isTrue = false;
                    break;
                }
            }
            Assert.IsTrue(isTrue);
        }
        [TestMethod]
        public void TestMethod2()
        {
            os.AddOrder(order1);
            os.AddOrder(order2);
            os.AddOrder(order3);
            os.Sort((o1, o2) => o1.OrderTotalPrice.CompareTo(o2.OrderTotalPrice));
            List<Order> result = new List<Order>() { order1, order3, order2 };
            bool isTrue = true;
            for (int i = 0; i < 3; i++)
            {
                if (os.OrderList[i] != result[i])
                {
                    isTrue = false;
                    break;
                }
            }
            Assert.IsTrue(isTrue);
        }

    }
}
