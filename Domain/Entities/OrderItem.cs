using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class OrderItem: BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
