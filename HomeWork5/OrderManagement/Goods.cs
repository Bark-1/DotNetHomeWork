using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    class Goods
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }

        public Goods(string goodsName, int goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }

        public override string ToString()
        {
            return $"GoodsName:{GoodsName}  Price:{GoodsPrice}";
        }
    }
}
