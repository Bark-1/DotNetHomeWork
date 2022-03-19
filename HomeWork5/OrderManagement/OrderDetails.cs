using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class OrderDetails
    {
        //货物 货物数量 该项货物的金额
        public Goods OrderGoods { get; set; }
        public int OrderGoodsNum { get; set; }
        public double OrderGoodsPrice { get => (OrderGoods.GoodsPrice * OrderGoodsNum); }

        public OrderDetails(Goods orderGoods, int orderGoodsNum)
        {
            OrderGoods = orderGoods;
            OrderGoodsNum = orderGoodsNum;
        }

        public override bool Equals(object obj)
        {
            OrderDetails od = obj as OrderDetails;
            return od != null && od.OrderGoods == OrderGoods && od.OrderGoodsNum == OrderGoodsNum;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderGoods, OrderGoodsNum);
        }

        public override string ToString()
        {
            return $"OrderGoods:{OrderGoods.GoodsName}  Number:{OrderGoodsNum}";
        }

    }
}
