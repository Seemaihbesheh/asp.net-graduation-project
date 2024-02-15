



using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;





namespace WebApplication3.DBContext
{
    public class CommentPost
    {
        [Key]
        public int id { get; set; }

        public string commentText { get; set; }





    }
}
