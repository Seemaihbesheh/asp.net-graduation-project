
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class CV_upload
    {
        [Key]
        public int id { get; set; }

        [Column("name", TypeName = "Varchar(max)")]
        public string name { get; set; }

        [Column("type", TypeName = "Varchar(max)")]
        public string type { get; set; }

  
 
    }
}
