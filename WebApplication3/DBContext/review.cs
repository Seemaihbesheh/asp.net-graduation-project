using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace WebApplication3.DBContext
{
    public class review
    {


        [Key]
        public int id { get; set; }

       
      
        public string UserName { get; set; }
      

        public string? ReviewContent { get; set; }


    }
}
