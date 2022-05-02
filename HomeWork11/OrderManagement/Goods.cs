using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrderManagement
{
    [Serializable]
    public class Goods
    {
        [Key, Column(Order = 1)]
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
            return $"{GoodsName}(¥{GoodsPrice})";
        }
    }
}
