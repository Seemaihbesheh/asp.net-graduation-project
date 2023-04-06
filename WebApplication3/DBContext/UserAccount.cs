using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{

    
        public class UserAccount
        {
            [Key]
            public int id { get; set; }

            [Required(ErrorMessage = "Bio is required")]
            public string bio { get; set; }

            [Required(ErrorMessage = "City is required")]
            public string city { get; set; }

            [Range(0, 4, ErrorMessage = "GPA must be between 0 and 4")]
            public int Gpa { get; set; }

            [Required(ErrorMessage = "CV ID is required")]
            public int cv_id { get; set; }

            [Required(ErrorMessage = "University is required")]
            public string? University { get; set; }

           // public bool State { get; set; }

            [Required(ErrorMessage = "Experience is required")]
            public int Experience { get; set; }

         //   [Required(ErrorMessage = "User ID is required")]


           // public int? User_idAccount { get; set; }

           
           // public User? user { get; set; }
        }


    }

