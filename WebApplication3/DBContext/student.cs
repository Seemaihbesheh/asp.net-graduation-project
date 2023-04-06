using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DBContext
{
    public class student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ages { get; set; }
        public int UniversityId { get; set; }
        public University? University { get; set; }
        public int? GenderId { get; set; }
        public Gender? Gender { get; set; }

        //public DateTime Created { get; set; }   


    }
}
