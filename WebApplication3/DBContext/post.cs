using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{
    public class post
    {
        [Key]
        

        public int Id { get; set; }

        public string text { get; set; }
      
        public bool flag_image { get; set; }

     
       
        public int image_id { get; set; }
    }
}
