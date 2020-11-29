using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("BOOKS")]
    public class Book
    {
        [Key]
        [Column("BOOK_ID")]
        public int Book_Id { get; set; }

        [Column("TITLE")]
        public string Title { get; set; }

        [Column("ISBN")]
        public string ISBN { get; set; }

        [Column("PRICE")]
        public double Price { get; set; }

        [ForeignKey("BOOKDETAIL")]
        public int BookDetail_Id { get; set; }

        public BookDetail BookDetail { get; set; }

        [ForeignKey("PUBLISHER")]
        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<BookAuthor> BookAuthor { get; set; }

    }
}
