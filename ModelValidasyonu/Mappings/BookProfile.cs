using AutoMapper;
using ModelValidasyonu.Enums;
using ModelValidasyonu.Models;
using ModelValidasyonu.ViewModels.BookViewModels;

namespace ModelValidasyonu.Mappings
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre,
                opt => opt.MapFrom(src => ((GenreEnum)src.GenreId))).ForMember(dest => dest.PublishDate,
                opt => opt.MapFrom(src => src.PublishDate.ToString("yyyy"))); 

            CreateMap<CreateBookViewModel, Book>();

            CreateMap<Book, BookDetailViewModel>().ForMember(dest => dest.Genre,
                opt => opt.MapFrom(src => ((GenreEnum)src.GenreId))).ForMember(dest => dest.PublishDate,
                opt => opt.MapFrom(src => src.PublishDate.ToString("yyyy")));
        }
    }
}