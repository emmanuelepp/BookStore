using System;
using BookStore_Model.Models;

namespace BookStoreManageAPI.Services
{
    public interface IBookStoreServices 
    {
        Category InsertBooks(Category category);
    }
}
