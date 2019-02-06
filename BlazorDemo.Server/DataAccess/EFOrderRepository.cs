using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDemo.Server.DataAccess
{
    public class EFOrderRepository : IOrderRepository
    {
        private OrderContext context;

        public EFOrderRepository(OrderContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders
            .Include(o => o.OrderItems);

        public IQueryable<OrderItem> OrderItems => context.OrderItems;

        public void AddNewOrder(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public void AddNewOrderItem(OrderItem orderItem)
        {
            context.OrderItems.Add(orderItem);
            context.SaveChanges();
        }
    }
}
