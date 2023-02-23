using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class CompanyAccount
    {

        [key]
        public int Id { get; set; }

        [Column("Name", TypeName = "Varchar(200)")]
        public string Name { get; set; }

        [Column("about", TypeName = "Varchar(max)")]
        public string about { get; set; }

        [Column("address", TypeName = "Varchar(max)")]

        public string address { get; set; }

        public string Email { get; set; }
        public int phoneNumber { get; set; }

        //here list
        public string services { get; set; }

        public int Company_id { get; set; }
    }
}
