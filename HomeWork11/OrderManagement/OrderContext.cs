using System;
using System.Data.Entity;
using System.Linq;

namespace OrderManagement
{
    public class OrderContext : DbContext
    {
        public OrderContext(): base("name=OrderDataBase")
        {
            Database.SetInitializer(
        new DropCreateDatabaseIfModelChanges<OrderContext>());
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