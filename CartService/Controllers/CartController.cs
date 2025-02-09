using Microsoft.AspNetCore.Mvc;

namespace CartService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        [HttpPost("add")]
        public IActionResult AddToCart(int userId, int bookId, int quantity)
        {
            // TODO: Implement adding item to cart in database or Redis
            return Ok(new { Message = $"Added {quantity} of book {bookId} to cart for user {userId}" });
        }

        [HttpGet("{userId}")]
        public IActionResult GetCart(int userId)
        {
            // TODO: Implement retrieving cart from database or Redis
            var cart = new
            {
                UserId = userId,
                Items = new[]
                {
                    new { BookId = 1, Quantity = 2, Price = 19.99m },
                    new { BookId = 2, Quantity = 1, Price = 29.99m }
                }
            };

            return Ok(cart);
        }
    }
}

