


using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;


namespace WebApplication3.DBContext
{
    public class skill
    {

        public int Id { get; set; } 
        public string skillone { get; set; }
        public string skilltwo { get; set; }
      



    }
}
