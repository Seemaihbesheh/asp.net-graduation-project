
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Controllers;

namespace WebApplication3.DBContext
{
    public class applyJob
    {
        [Key]
        public int Id { get; set; }

        public string Full_Name { get; set; }

        public string Email { get; set; }
        public string City { get; set; }

        public int Phone_Number { get; set; }
        public int GPA { get; set; }


        public string? ProductImage { get; set; }

        public string? FileDisplayName { get; set; }

        public int pushJobid { get; set; }
        public pushJob? pushJob { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }





        //untill now i don't add forgin key for company


    }
}

