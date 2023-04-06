using System.Runtime.Serialization;

namespace WebApplication3.DBContext
{
    public class University
    {

        public int Id { get; set; }

        public string UniversityName { get; set; }

        public string address { get; set; }

        [IgnoreDataMember]
        public ICollection<student> students { get; set; }

    }
}
