

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace WebApplication3.DBContext
{
    public class postwithoutPhoto
    {
        [Key]
        public int Id { get; set; }
        public string? text { get; set; }

     
    }
}
