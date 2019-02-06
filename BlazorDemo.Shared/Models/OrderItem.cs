using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Comment { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
