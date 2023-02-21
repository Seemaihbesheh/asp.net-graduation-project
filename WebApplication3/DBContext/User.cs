
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{
    public class User
    {
        [Key]
        public int Id { get; set; }
       [Column("First_Name", TypeName = "Varchar(200)")]
        public string  First_Name { get; set; }
        [Column("Last_Name", TypeName = "Varchar(200)")]

        public string Last_Name { get; set; }


        public int phoneNumber { get; set; }

        public string Email { get; set; }

        public string password  { get; set; }






    }

}
