using System.ComponentModel.DataAnnotations;

namespace ModelValidasyonu.ViewModels.BookViewModels
{
    public class CreateBookViewModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
