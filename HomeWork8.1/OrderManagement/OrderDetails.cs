using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    [Serializable]
    public class OrderDetails
    {
        //货物 货物数量 该项货物的金额
        public Goods OrderGoods { get; set; }
        public int OrderGoodsNum { get; set; }
        public double OrderGoodsPrice { get => (OrderGoods.GoodsPrice * OrderGoodsNum); set { } }

        public OrderDetails(Goods orderGoods, int orderGoodsNum)
        {
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
