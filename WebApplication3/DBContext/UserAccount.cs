using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{

    public class UserAccount
    {
        [Key]
        public int Id { get; set; }
        [Column("bio", TypeName = "Varchar(max)")]
        public string bio { get; set; }
        [Column("city", TypeName = "Varchar(max)")]

        public string city { get; set; }


        public int Gpa  { get; set; }

        public int  cv_id  { get; set; }

        public string University { get; set; }

        public bool State  { get; set; }


        public int  Experience { get; set; }
        public int User_idAccount { get; set; }
        
        [ForeignKey("User_idAccount")]
        public User user { get; set; }

    }
}
