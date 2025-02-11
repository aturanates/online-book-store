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
                new { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 9.99m },
                new { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 12.99m },
                new { Id = 3, Title = "1984", Author = "George Orwell", Price = 10.99m }
            };

            return Ok(books);
        }
    }
}

