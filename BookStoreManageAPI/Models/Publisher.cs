using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("PUBLISHER")]
    public class Publisher
    {
        [Key]
        [Column("PUBLISHER_ID")]
        public int Publisher_Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("LOCATION")]
        public string Location { get; set; }

        public List<Book> Books { get; set; }
    }
}
