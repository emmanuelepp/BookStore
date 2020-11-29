using System.Net.Http;
using BookStore_Model.Models;
using BookStoreManageAPI.DataAccess;

namespace BookStoreManageAPI.Services
{
    public class BookStoreServices : IBookStoreServices
    {
        private readonly ApiDbContext _DbConetext;
        private readonly HttpClient _HttpClient;

        public BookStoreServices(ApiDbContext dbConetext, HttpClient httpclient)
        {
            _DbConetext = dbConetext;
            _HttpClient = httpclient;
        }

        public Category InsertBooks(Category category)
        {
            Category result = new Category
            {
                CategoryId = category.CategoryId,
                Name = category.Name
            };

            _DbConetext.Categories.Add(result);
            _DbConetext.SaveChanges();

            return result;
        }

    }
}
