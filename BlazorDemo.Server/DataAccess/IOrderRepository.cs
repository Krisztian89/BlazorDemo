using BlazorDemo.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Server.DataAccess
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        IQueryable<OrderItem> OrderItems { get; }

        void AddNewOrder(Order order);
        void AddNewOrderItem(OrderItem orderItem);
    }
}
