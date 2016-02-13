namespace LibrarySystem.Web.Models.Books
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;

    using LibrarySystem.Models;
    using LibrarySystem.Web.Mappings;

    public class BookViewModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public string ShortReview { get; set; }

        public DateTime DateCreate { get; set; }

        public string CreatorName { get; set; }

        public string CreatorEmail { get; set; }

        public string CategoryName { get; set; }

        public string Author { get; set; }
         
        public ICollection<string> AuthorBooks { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.CreatorName, opt => opt.MapFrom(source => source.Category.Name));

            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.CreatorEmail, opt => opt.MapFrom(source => source.User.Email));

            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.CreatorName, opt => opt.MapFrom(source => source.User.UserName));

            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.Author, opt => opt.MapFrom(source => source.Author.Name));

            configuration.CreateMap<Book, BookViewModel>()
                .ForMember(dest => dest.AuthorBooks, opt => opt.MapFrom(source => source.Author.Books.Select(b => b.Title)));
        }
    }
}