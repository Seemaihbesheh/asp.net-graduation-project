using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{
    public class Cv_Creat
    {
        [Key]
        public int Id { get; set; }

        [Column("AboutMe", TypeName = "Varchar(max)")]
        public string AboutMe { get; set; }

        [Column("Skills", TypeName = "Varchar(max)")]
        public string Skills { get; set; }

        public string Languages { get; set; }
        public int Gpa { get; set; }

     

        public string University { get; set; }

        public string Education { get; set; }
        public string Contact  { get; set; }

        public int ExperienceYear { get; set; }
        public int User_idCv_Creat { get; set; }
        [ForeignKey("User_idCv_Creat")]
        public User user { get; set; }



    }
}
