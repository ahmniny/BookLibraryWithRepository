using BookLibraryWithRepository.Interfaces;
using BookLibraryWithRepository.Models;
using Microsoft.AspNetCore.Mvc;

namespace RespositoryPatternWithUOW.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IBaseRepository<Author> _repo;

        public AuthorsController(IBaseRepository<Author> repo)
        {
            _repo = repo;
        }

        [HttpGet("get-by-id/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetByIdAsync(id));
        }
    }
}