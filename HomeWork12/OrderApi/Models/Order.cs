using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderApi.Models
{
    [Serializable]
    public class Order:IComparable
    {
        // 订单号 客户 订单金额 
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        public Customer OrderCustomer { get; set; }

        public double OrderTotalPrice
        {
            get
            {
                if (OrderDtlList == null) return 0;
                double sum = 0;
                OrderDtlList.ForEach(od => sum += od.OrderGoodsPrice);
                return sum;
            }
            set { }
        }
        public String AllGoods 
        { 
            get
            {
                if (OrderDtlList == null) return "";
                StringBuilder stringBuilder = new StringBuilder();
                OrderDtlList.ForEach(orderdt => { stringBuilder.Append(orderdt.ToString() + ","); });
                return stringBuilder.ToString();
            }
        }
        //订单明细
        //一个Order有多个明细，每个明细包含一个货物以及该货物的数量、金额
        public List<OrderDetails> OrderDtlList { get; set; }

        public Order(int orderID, Customer orderCustomer, List<OrderDetails> orderDtlList)
        {
            OrderID = orderID;
            OrderCustomer = orderCustomer;
            OrderDtlList = orderDtlList;
        }
        public Order() { }

        public void AddOrderDetails(OrderDetails newOrderDetails)
        {
            if (newOrderDetails == null) { throw new Exception("Invalid OrderDetails"); }
            //判断订单明细是否重复（已存在）
            bool valid = true;
            foreach (OrderDetails od in OrderDtlList)
            {
                if (!valid) break;
                valid = !od.Equals(newOrderDetails);
            }
            if (valid) OrderDtlList.Add(newOrderDetails);
            else throw new Exception("The same OrderDetails exists");
        }

        public override bool Equals(Object obj)
        {
            Order order = obj as Order;
            return order != null && order.OrderID == OrderID;
        }

        public override int GetHashCode()
        {
            return OrderID;
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder("    The OrderDetails:\n");
            foreach(OrderDetails od in OrderDtlList)
            {
                strBuilder.AppendLine("    "+od.ToString());
            }
            return $"OrderID:{OrderID}  CustomerName:{OrderCustomer.CustomerName}  CustomerPhone:{OrderCustomer.PhoneNumber } TotalPrice:{OrderTotalPrice}\n"
                        + strBuilder.ToString();
        }
        //排序，实现CompareTo给OrderService用于实现排序
        public int CompareTo(object obj2)
        {
            if (!(obj2 is Order)) throw new System.ArgumentException();
            Order order2 = (Order)obj2;
            return this.OrderID.CompareTo(order2.OrderID);
        }
    }
}
