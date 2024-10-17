using Grimoire.Order.Models.Entities;
using Grimoire.Order.Services;
using Microsoft.AspNetCore.Mvc;

namespace Grimoire.Order.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {

        private readonly OrderService _orderService;
        public OrderController(OrderService orderService) {
            _orderService = orderService;
        }
        [HttpGet]
        [Route("/Test2")]
        public IActionResult Test2()
        {
            return Ok("Running");
        }

        [HttpPost]
        public IActionResult Order(GmoOrder orderReq)
        {
            return Ok(_orderService.CreateOrder(orderReq));
        }
    }

}
