using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace WebApplication3.DBContext
{
    public class cv
    {

        [Key]
        public int Id { get; set; }


        public string Name { get; set; }

        public string Email { get; set; }


        public string AboutMe { get; set; }


        public string Skills { get; set; }


        public string Languages { get; set; }

        public int Gpa { get; set; }

        public string University { get; set; }


        public int phone_number { get; set; }

        public int ExperienceYear { get; set; }


        public int ?useruid { get; set; }
        public userU? useru { get; set; }


    }
}
