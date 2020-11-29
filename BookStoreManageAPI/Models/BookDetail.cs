using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("BOOK_DETAIL")]
    public class BookDetail
    {

        [Key]
        public int BookDetail_Id { get; set; }

        public int NumberOfChapters { get; set; }

        public int NumberOfPagues { get; set; }

        public string Weight { get; set; }

        public Book Book { get; set; }
    }
}
