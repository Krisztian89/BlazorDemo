using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Comment { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
