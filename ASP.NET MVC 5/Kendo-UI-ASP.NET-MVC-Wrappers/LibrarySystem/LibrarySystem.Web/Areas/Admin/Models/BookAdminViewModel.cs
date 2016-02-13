namespace LibrarySystem.Web.Areas.Admin.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using AutoMapper;
    using LibrarySystem.Models;
    using Mappings;

    public class BookAdminViewModel : IMapFrom<Book>, IHaveCustomMappings
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string ISBN { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreate { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Book, BookAdminViewModel>()
                .ForMember(b => b.Category, opt => opt.MapFrom(m => m.Category.Name));

            configuration.CreateMap<Book, BookAdminViewModel>()
                .ForMember(b => b.Author, opt => opt.MapFrom(m => m.Author.Name));
        }
    }
}