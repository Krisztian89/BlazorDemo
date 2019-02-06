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
        [Route("api/orders/")]
        public async Task<IEnumerable<Order>> GetOrders()
        {
            var result = await repository.Orders.ToListAsync();
            return result;
        }
    }
}