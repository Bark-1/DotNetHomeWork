using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement
{
    [Serializable]
    public class Goods
    {
        public string GoodsName { get; set; }
        public int GoodsPrice { get; set; }

        public Goods(string goodsName, int goodsPrice)
        {
            GoodsName = goodsName;
            GoodsPrice = goodsPrice;
        }
        public Goods() { }

        public override string ToString()
        {
            return $"GoodsName:{GoodsName}  Price:{GoodsPrice}";
        }
    }
}
