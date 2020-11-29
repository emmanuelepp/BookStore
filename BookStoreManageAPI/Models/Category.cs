using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("CATEGORY")]
    public class Category
    {
        [Key]
        [Column("CATEGORY_ID")]
        public int CategoryId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }
}
