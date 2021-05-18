using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public OrdersController(OrderDbContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string name)
        {
            IQueryable<Order> query = _context.Orders;
            if(name != null)
            {
                query = query.Where(order => order.Client == name);
            }
            return query.ToList();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(long id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.OrderId == id); ;
            if(order == null)
            {
                return NotFound();
            }
            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(long id,Order order)
        {
            if(order.OrderId != id)
            {
                return BadRequest("this cannot be modified!");
            }
            try
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                string error = e.Message;
                if(e.InnerException != null)
                {
                    error = e.InnerException.Message;
                }
                return BadRequest(error);
            }
            return order;
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public ActionResult<Order> DeleteOrder(long id)
        {
            try
            {
                var order = _context.Orders.FirstOrDefault(o => o.OrderId == id);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    _context.SaveChanges();
                }
            }catch(Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
