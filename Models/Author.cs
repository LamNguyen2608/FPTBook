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
        [Required(ErrorMessage = "Profile Prciture is required")]
        public string ProfilePicURL { get; set; }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Fullname { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        public List<Book> Books { get; set; }
    }
}