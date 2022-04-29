using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FPTBook.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePicURL { get; set; }

        [Display(Name = "Full name")]
        public string Fullname { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        public List<Book> Books { get; set; }
    }
}