using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryWithRepository.Models
{
    [Index(nameof(Title), IsUnique = true)]
    public class Book
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        //public string? Description { get; set; }

        public int Year { get; set; }

        public int AuthorId { get; set; }
        public Author? Author { get; set; }
        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
    }
}