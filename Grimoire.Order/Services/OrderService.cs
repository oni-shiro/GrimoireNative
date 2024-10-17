using Grimoire.Order.Data;
using Grimoire.Order.Models.Dtos;
using Grimoire.Order.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Grimoire.Order.Services
{

    
    public class OrderService

    {
        private readonly OrderContext _dbContext;
        public OrderService(OrderContext orderContext) {
            _dbContext = orderContext;
        }

        public GmoOrder CreateOrder(GmoOrder orderReq)
        {
            _dbContext.Orders.Add(orderReq);
            _dbContext.SaveChanges();
            return orderReq;

        }
    }
}
