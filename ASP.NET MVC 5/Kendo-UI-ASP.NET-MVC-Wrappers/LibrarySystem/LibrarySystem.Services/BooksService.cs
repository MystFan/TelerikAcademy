namespace LibrarySystem.Services
{
    using System;
    using System.Linq;
    using LibrarySystem.Models;
    using LibrarySystem.Data.Repositories;
    using LibrarySystem.Services.Contracts;

    public class BooksService : IBooksService
    {
        private const int DefaultPageSize = 3;
        private IRepository<Book> books;
        private IRepository<Category> categories;

        public BooksService(IRepository<Book> booksRepo, IRepository<Category> categpriesRepo)
        {
            this.books = booksRepo;
            this.categories = categpriesRepo;
        }

        public void Add(string title, string review, string ISBN, string userId, string author, int categoryId)
        {
            var newBook = new Book()
            {
                Title = title,
                ShortReview = review,
                ISBN = ISBN,
                DateCreate = DateTime.Now,
                Author = new Author()
                {
                    Name = author
                },
                UserId = userId,
                CategoryId = categoryId
            };

            this.books.Add(newBook);
            this.books.SaveChanges();
        }

        public void Delete(int id)
        {
            this.books.Delete(id);
            this.books.SaveChanges();
        }

        public IQueryable<Book> GetAll()
        {
            return this.books.All();
        }

        public IQueryable<Book> GetAll(int page = 0, int pageSize = DefaultPageSize)
        {
            return this.books
                        .All()
                        .OrderByDescending(b => b.DateCreate)
                        .Skip(page * pageSize)
                        .Take(pageSize);
        }

        public IQueryable<Book> GetByTitle(string title)
        {
            return this.books
                .All()
                .Where(b => b.Title.ToLower().Contains(title.ToLower()));
        }

        public void Update(int id, string title, string content, string ISBN)
        {
            var dbBook = this.books.All().FirstOrDefault(b => b.Id == id);

            dbBook.Title = title;
            dbBook.ShortReview = content;
            dbBook.ISBN = ISBN;

            this.books.Update(dbBook);
            this.books.SaveChanges();
        }
    }
}
