using BookStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {


        private static List<Book> books = new List<Book>
    {
        new Book { BookId = 1, BookTitle = "C# Basics", Author = "Ali" },
        new Book { BookId = 2, BookTitle = "ASP.NET Core", Author = "Ahmed" }
    };


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(books);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            return Ok(book);
        }


        [HttpPost]
        public IActionResult Create(Book book)
        {           
            books.Add(book);
            return Ok(books);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            book.BookTitle = updatedBook.BookTitle;
            book.Author = updatedBook.Author;
            return Ok(book);
        }

     
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            books.Remove(book);
            return Ok(books);
        }
    }

}

