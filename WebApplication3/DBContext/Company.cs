
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "Varchar(200)")]
        public string Name { get; set; }


        public int phoneNumber { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

    }
}
