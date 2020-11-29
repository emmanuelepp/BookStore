using BookStore_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManageAPI.DataAccess
{
    public class ApiDbContext : DbContext, IApiDbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Category>  Categories {get;set;}
    }
}
