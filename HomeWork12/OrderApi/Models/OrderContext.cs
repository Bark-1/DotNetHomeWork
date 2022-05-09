using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace OrderApi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDtlList { get; set; }
        public DbSet<Goods> OrderGoods { get; set; }
        public DbSet<Customer> OrderCustomer { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}