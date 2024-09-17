using System.ComponentModel.DataAnnotations;

namespace E-commerceClothingWebApp.Models
{
    public class User
    {
        [Key] // Primary key for the User entity
        public int UserId
         {

             get;
             private set;
        }

        [Required]//Your Name is required
        [StringLength(100)]// Maximum length of 100 characters
        [Display(Name = "Full Name")]// Display name for UI
        public string Name 
          {

             get;
             set;
        }
       
        [Required] // Email is required
        [EmailAddress] // Email is required
        [Display(Name = "Email Address")]// Display name for UI
        public string Email
          {

             get;
             set;
        }

        [Required] // Password is required
        [DataType(DataType.Password)] // Treat as a password (masked input).
        public string Password 
          {

             get;
             set;
        }
    }
}