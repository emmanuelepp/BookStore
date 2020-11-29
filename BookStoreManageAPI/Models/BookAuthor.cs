using System;
using System.ComponentModel.DataAnnotations;

namespace BookStore_Model.Models
{
    public class BookAuthor
    {
        //[Key]
        public int BookId { get; set; }

        //[key]
        public int AuthorId { get; set; }

        public Book Book { get; set; }

        public Author Author { get; set; }
    }
}
