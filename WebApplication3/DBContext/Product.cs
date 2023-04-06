using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? ProductName { get; set; }
        public string? ProductImage { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}