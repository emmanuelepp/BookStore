using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("GENRES")]
    public class Genres
    {
        public Genres()
        {
        }

        [Key]
        [Column("GENRES_ID")]
        public int GenresId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }
}
