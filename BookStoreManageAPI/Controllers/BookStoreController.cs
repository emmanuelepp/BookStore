using BookStore_Model.Models;
using BookStoreManageAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStoreManageAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookStoreController : ControllerBase
    {
        readonly BookStoreServices _bookStoreServices;

        public BookStoreController( BookStoreServices bookStoreServices)
        {
            _bookStoreServices = bookStoreServices;
        }

        [HttpPost]
        public string InsertBooks(Category category)
        {
            _bookStoreServices.InsertBooks(category);

            return "";
        }
    }
}
