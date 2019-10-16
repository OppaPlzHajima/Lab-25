using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackBuster.Models
{
    public class User
    {
        [Key]

        [Required(ErrorMessage = "Please enter a creative username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [StringLength(100, ErrorMessage = "Password must be between 2 to 100 characters", MinimumLength = 2)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Your Last Name is Required")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Social Security # is required")]
        public string SSN { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "What's Your Favorite movie?")]
        public string FavMovie { get; set; }


    }
}
