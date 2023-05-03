
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;







namespace WebApplication3.DBContext
{
    public class Admin
    {


        [Key]
        public int id { get; set; }

        [Column("Name", TypeName = "Varchar(200)")]
        public string Name { get; set; }

        public int phoneNumber { get; set; }

        public string Email { get; set; }

        public string password { get; set; }

        [Column("about", TypeName = "Varchar(max)")]
        public string about { get; set; }

        [Column("address", TypeName = "Varchar(max)")]

        public string address { get; set; }
        public string Languages { get; set; }

    }
}
