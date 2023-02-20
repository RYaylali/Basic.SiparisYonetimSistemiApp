using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SYS.Application.Models.DTOs;
using SYS.Application.Service.OrderService;
using SYS.Domain.Entities;

namespace SYS.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<ActionResult> CreateOrder(AddOrderDTO order)
        {
            string message = await _orderService.CreateOrder(order);
            if (message == null)
            {
                return BadRequest("Geçersiz veri.");
            }
            return Ok(message);
        }
    }
}
