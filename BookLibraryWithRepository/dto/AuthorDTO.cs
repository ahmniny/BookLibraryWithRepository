using System.ComponentModel.DataAnnotations;

namespace BookLibraryWithRepository.dto
{
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Bio { get; set; }

    }
}
