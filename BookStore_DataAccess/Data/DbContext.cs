using Microsoft.EntityFrameworkCore;
using BookStore_Model.Models;
using Microsoft.Extensions.Configuration;

namespace BookStore_DataAccess.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        {

        }


        public DbSet<Category> Categories {get; set;}

        public DbSet<Genres> Genres { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API configuration goes here
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });
        }

    }
}
