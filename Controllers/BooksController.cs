using Microsoft.AspNetCore.Mvc;
using LibraryApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Quantity = 3 },
            new Book { Id = 2, Title = "The Hobbit", Author = "J.R.R. Tolkien", Quantity = 5 }
        };

        [HttpGet]
        public ActionResult<List<Book>> GetAll() => books;

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            book.Id = books.Any() ? books.Max(b => b.Id) + 1 : 1;
            books.Add(book);
            return Ok(book);
        }

        [HttpPost("lend/{id}")]
        public ActionResult LendBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null || book.Quantity <= 0)
                return BadRequest("Book unavailable.");
            book.Quantity--;
            return Ok(book);
        }

        [HttpPost("return/{id}")]
        public ActionResult ReturnBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return BadRequest("Book not found.");
            book.Quantity++;
            return Ok(book);
        }
    }
}
