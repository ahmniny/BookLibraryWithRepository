using BookLibraryWithRepository;
using BookLibraryWithRepository.dto;
using BookLibraryWithRepository.Interfaces;
using BookLibraryWithRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace RespositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBaseRepository<Book> _repo;

        public BooksController(IBaseRepository<Book> repo)
        {
            _repo = repo;
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_repo.GetAll());
        }

        // include author
        [HttpGet("GetByName/{title}")]
        public IActionResult GetByTitle(string title)
        {
            return Ok(_repo.Find(b => b.Title == title, new[] { "Author" }));
        }

        [HttpGet("GetOrderedByTitle/{title}")]
        public IActionResult GetOrdered(string title)
        {
            return Ok(_repo.FindAll(b => b.Title.Contains(title), null, null, b => b.Id, OrderBy.Descending));
        }

        [HttpPost("add-book")]
        public IActionResult AddOne([FromBody] BookDTO book)
        {
            var _book = _repo.Add(new Book
            {
                AuthorId = book.AuthorId,
                Title = book.Title,
                Year = book.Year
            });
            
            return Ok(_book);
        }
    }
}