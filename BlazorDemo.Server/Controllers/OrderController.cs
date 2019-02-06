using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Server.DataAccess;
using BlazorDemo.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Server.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository repository;

        public OrderController(IOrderRepository repo)
        {
            repository = repo;
        }

        [HttpGet]
        [Route("api/order/")]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var result = await repository.Orders.ToListAsync();
            return result;
        }

        [HttpGet("api/order/{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await repository.Orders.FirstOrDefaultAsync(o => o.OrderId == id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
    }
}