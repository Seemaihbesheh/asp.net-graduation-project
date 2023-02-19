
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{
    public class User
    {
      //  [Key]
        public int Id { get; set; }
   //     [Column("PrductName", TypeName = "Varchar(200)")]
        public string Name { get; set; }

        public int phoneNumber { get; set; }
    }
}
