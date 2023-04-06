
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Controllers;

namespace WebApplication3.DBContext
{
    public class Profile
    {


        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
    }
}
