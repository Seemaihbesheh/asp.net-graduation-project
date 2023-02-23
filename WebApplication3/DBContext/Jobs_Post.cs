


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class Jobs_Post
    {
        [Key]
        public int Id { get; set; }
     
        public string Description { get; set; }
        [Column("Pre_title", TypeName = "Varchar(200)")]

        public string Pre_title { get; set; }

        [Column("Title", TypeName = "Varchar(200)")]
        public string Title { get; set; }

        public string Company_id { get; set; }

        public string Requrment { get; set; }
        public string Place  { get; set; }
        public int Job_Deadline { get; set; }



    }
}
