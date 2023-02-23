
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "Varchar(max)")]
        public string text { get; set; }


        public int User_id { get; set; }

        public int Job_postId { get; set; }

     

    }
}
