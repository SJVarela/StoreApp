using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Order: BaseEntity
    {
        public Order()
        {
        }

        public string BuyerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public List<OrderItem> Items { get; set; }

    }
}
