using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class notifications
    {
        [Key]
        public int Id { get; set; }
        [Column("notificat_text", TypeName = "Varchar(max)")]
        public string notificat_text { get; set; }

        public int User_idnotifications { get; set; }

        [ForeignKey("User_idnotifications")]
        public User user { get; set; }
    }
}
