using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement
{
    [Serializable]
    public class OrderDetails
    {
        //货物 货物数量 该项货物的金额
        [Key]
        public int OrderDtlID {get;set;}
        public Goods OrderGoods { get; set; }

        public int OrderGoodsNum { get; set; }

        [NotMapped]
        public double OrderGoodsPrice { get => (OrderGoods.GoodsPrice * OrderGoodsNum); set { } }

        public int OrderID { get; set; } 

        [ForeignKey("OrderID")]
        public Order Order { get; set; }

        public OrderDetails(int orderID, Goods orderGoods, int orderGoodsNum)
        {
            OrderID = orderID;
            OrderGoods = orderGoods;
            OrderGoodsNum = orderGoodsNum;
        }
        public OrderDetails() { }

        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od != null && od.OrderGoods == OrderGoods && od.OrderGoodsNum == OrderGoodsNum;
        }

        public override string ToString()
        {
            return $"({OrderGoods.GoodsName}*{OrderGoodsNum})";
        }

        public override int GetHashCode()
        {
            int hashCode = -112596332;
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(OrderGoods);
            hashCode = hashCode * -1521134295 + OrderGoodsNum.GetHashCode();
            return hashCode;
        }
    }
}
