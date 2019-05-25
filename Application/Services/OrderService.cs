using Application.Services.Interfaces;
using Domain.Entities;
using Persistance.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class OrderService : IOrderService
    {
        StoreDbContext _context;
        public OrderService(StoreDbContext context)
        {
            _context = context;
        }
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
        }
    }
}
