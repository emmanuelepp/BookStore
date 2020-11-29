using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BookStore_Model.Models;
using BookStoreManageAPI.DataAccess;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApiDbContext _apiDbContext;
        private readonly HttpClient _HttpClient;

        public CategoryController(ApiDbContext apiDbContext,HttpClient httpClient)
        {
            _apiDbContext = apiDbContext;
            _HttpClient = httpClient;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Category> objList = _apiDbContext.Categories.ToList();

            return View(objList);
        }
    }
}
