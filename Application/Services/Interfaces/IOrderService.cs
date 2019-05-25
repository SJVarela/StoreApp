using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services.Interfaces
{
    public interface IOrderService
    {
        void AddOrder(Order order);
    }
}
