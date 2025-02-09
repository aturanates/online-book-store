using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBooks()
        {
            // TODO: Implement book retrieval from database
            var books = new[]
            {
                new { Id = 1, Title = "Book 1", Author = "Author 1", Price = 19.99m },
                new { Id = 2, Title = "Book 2", Author = "Author 2", Price = 29.99m }
            };

            return Ok(books);
        }
    }
}

