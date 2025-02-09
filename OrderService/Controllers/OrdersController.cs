using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateOrder(int userId)
        {
            // TODO: Implement order creation logic
            // 1. Get cart items from Cart Service
            // 2. Create order in database
            // 3. Process payment
            // 4. Clear cart
            return Ok(new { OrderId = 1, Message = $"Order created for user {userId}" });
        }

        [HttpGet("{userId}")]
        public IActionResult GetOrders(int userId)
        {
            // TODO: Implement retrieving orders from database
            var orders = new[]
            {
                new { OrderId = 1, Date = DateTime.Now, Total = 69.97m, Status = "Shipped" },
                new { OrderId = 2, Date = DateTime.Now.AddDays(-1), Total = 39.98m, Status = "Processing" }
            };

            return Ok(orders);
        }
    }
}

