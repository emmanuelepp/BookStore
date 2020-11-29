using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore_Model.Models
{
    [Table("AUTHOR")]
    public class Author
    {
        [Key]
        public int Publisher_Id { get; set; }

        public string FirtsName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Location { get; set; }

        public object Fullname
        {
            get
            {
                return $"{FirtsName} {LastName}";
            }
        }

        public ICollection<BookAuthor> BookAuthor { get; set; }


    }
}
