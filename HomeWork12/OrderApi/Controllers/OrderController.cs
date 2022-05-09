using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext orderDb;
        public OrderController(OrderContext context)
        {
            this.orderDb = context;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)
        {
            var order = orderDb.Orders
                    .Include(o => o.OrderCustomer)
                    .Include(o => o.OrderDtlList)
                    .ThenInclude(od => od.OrderGoods)
                    .FirstOrDefault(o => o.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetAllOrder()
        {
            IQueryable<Order> query = orderDb.Orders
                .Include(o=>o.OrderCustomer)
                .Include(o => o.OrderDtlList)
                .ThenInclude(od => od.OrderGoods);
            return query.ToList();
        }

        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryOrders(string clientName, double money, int skip, int take)
        {
            var query = buildQuery(clientName, money).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<Order> buildQuery(string clientName, double? money)
        {
            var query = orderDb.Orders.Include("OrderDetails");
            if (clientName != null)
            {
                query = query.Include(o => o.OrderCustomer).Where(o => o.OrderCustomer.CustomerName.Equals(clientName));
            }
            if (money != null)
            {
                query = query.Where(o => o.OrderTotalPrice>=money);
            }
            query = query.Include(o => o.OrderDtlList).ThenInclude(o => o.OrderGoods);
            return query;
        }
        // POST: api/todo
        [HttpPost]
        public ActionResult<Order> PostOrder(Order newOrder)
        {
            try
            {
                orderDb.Orders.Add(newOrder);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return newOrder;
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(long id, Order order)
        {
            if (id != order.OrderID)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                var delete = orderDb.Orders.FirstOrDefault(o => o.OrderID == id);
                orderDb.Orders.Remove(delete);
                orderDb.Orders.Add(order);
                orderDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(long id)
        {
            try
            {
                var delete = orderDb.Orders.FirstOrDefault(o => o.OrderID == id);
                if (delete != null)
                {
                    orderDb.Orders.Remove(delete);
                    orderDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
