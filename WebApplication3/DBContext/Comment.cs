
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Column("text", TypeName = "Varchar(max)")]
        public string text { get; set; }


        public int User_idComment { get; set; }

        public int Job_postId { get; set; }
     
      

     

    }
}
