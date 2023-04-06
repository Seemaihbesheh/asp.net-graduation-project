using System.Runtime.Serialization;

namespace WebApplication3.DBContext
{
    public class Gender
    {

        public int Id { get; set; }
        public string GenderName { get; set; }
        [IgnoreDataMember]
        public ICollection<student> students { get; set; }
    }
}
