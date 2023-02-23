
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class image_post
    {

        [Key]
        public int id { get; set; }

        [Column("image_name", TypeName = "Varchar(max)")]
        public string image_name { get; set; }

        [Column("image_file", TypeName = "Varchar(max)")]
        public string image_file { get; set; }

        [Column("image_type", TypeName = "Varchar(max)")]
        public string image_type { get; set; }
    }
}
