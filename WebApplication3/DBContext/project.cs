

using System.ComponentModel.DataAnnotations;



namespace WebApplication3.DBContext
{
    public class project
    {

        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Decription { get; set; }
      

    }
}
