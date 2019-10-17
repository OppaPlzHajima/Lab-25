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

        //[Required(ErrorMessage = "Please enter a creative username")]
        //public string UserName { get; set; }

        //[Required(ErrorMessage = "Please enter a password")]
        //[StringLength(100, ErrorMessage = "Password must be between 2 to 100 characters", MinimumLength = 2)]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Required(ErrorMessage = "Please enter your First Name")]
        //public string FirstName { get; set; }

        //[Required(ErrorMessage = "Your Last Name is Required")]
        //public string LastName { get; set; }
        
        //[Required(ErrorMessage = "Social Security # is required")]
        //public string SSN { get; set; }

        //[Required(ErrorMessage = "Email is required")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "What's Your Favorite movie?")]
        //public string FavMovie { get; set; }


        [Required(ErrorMessage = "The name of the item should not be empty")]
        [RegularExpression(@"[a-zA-Z\s]{0,20}", ErrorMessage = "The max length is 20 characters")]
        //  \s is for white space
        //@ is to espace the \ character
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the item price")]
        [Range(1, 150, ErrorMessage = "The price range is from 1 - 150")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Please enter a quantity above 0.")]
        [Range(1, 1000, ErrorMessage = "Quantity in  0- 1000")]
        public float Quantity { get; set; }
        [Required(ErrorMessage = "Description is null")]
        [MaxLength(2000, ErrorMessage = "Character limit is 2000")]
        public string Description { get; set; }


    }
}
