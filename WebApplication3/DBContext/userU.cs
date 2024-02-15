using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

using System.ComponentModel.DataAnnotations.Schema;
namespace WebApplication3.DBContext
{
    public class userU
    {

        [Key]
        public int Id { get; set; }
      
   
        public string UserName { get; set; }

        [Column("First_Name", TypeName = "Varchar(Max)")]
        public string ?FirstName { get; set; }

        [Column("Last_Name", TypeName = "Varchar(200)")]

        public string ?LastName { get; set; }


        public int ?phoneNumber { get; set; }

        public string ?City { get; set; }

        public string ?Bio { get; set; }
       public string? Experience { get; set; }

        public string ?State { get; set; }
        public string ?Email { get; set; }

        public int ?GPA { get; set; }
        public string ?Education { get; set; }

        public string ?password { get; set; }
        public string ?Token { get; set; }
        public string ?Role { get; set; }

    public string ?ResetPasswordToken { get; set; }


     

        [IgnoreDataMember]
      public ICollection<applyJob>? applyJobs { get; set; }


        [IgnoreDataMember]
        public ICollection<cv>? cvs { get; set; }

      


      //  [IgnoreDataMember]
      //  public Resume? Resumes { get; set; }
    }
}
