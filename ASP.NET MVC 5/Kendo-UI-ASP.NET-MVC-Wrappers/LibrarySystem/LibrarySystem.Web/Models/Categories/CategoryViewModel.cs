namespace LibrarySystem.Web.Models.Categories
{
    using LibrarySystem.Models;
    using LibrarySystem.Web.Mappings;

    public class CategoryViewModel : IMapFrom<Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}