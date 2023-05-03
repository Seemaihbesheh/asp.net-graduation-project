

using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebApplication3.DBContext
{
    public class Company
    {

        [Key]
        public int id { get; set; }

        // [Column("Name", TypeName = "Varchar(200)")]
        //public string Name { get; set; }
        //UserName
        [Column("UserName", TypeName = "Varchar(200)")]
        public string UserName { get; set; }
        public int ?phoneNumber { get; set; }

        public string ?Email { get; set; }

        public string ?password { get; set; }

        [Column("about", TypeName = "Varchar(max)")]
        public string ?about { get; set; }

        [Column("address", TypeName = "Varchar(max)")]

        public string ?address { get; set; }

      
        //here list
        public string ?services_title { get; set; }
        public string ?services_about { get; set; }
        public string ?Token { get; set; }
        public string ?Role { get; set; }


        [IgnoreDataMember]
        public ICollection<pushJob>? pushJobs { get; set; }

    }
}
