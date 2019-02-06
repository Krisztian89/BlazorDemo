using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Server.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository repository;

        public OrderController(IOrderRepository repo)
        {
            repository = repo;
        }
    }
}