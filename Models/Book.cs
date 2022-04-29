using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Rating { get; set; }

        public int catId { get; set; }
        [ForeignKey("catId")]
        public Category category { get; set; }

        public int authorId { get; set; }
        [ForeignKey("authorId")]
        public Author author { get; set; }

    }
}