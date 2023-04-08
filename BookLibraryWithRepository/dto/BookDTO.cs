
namespace BookLibraryWithRepository.dto
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Year { get; set; }

        public int AuthorId { get; set; }
    }
}
