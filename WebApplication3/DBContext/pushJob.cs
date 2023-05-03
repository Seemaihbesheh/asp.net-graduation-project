


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;


namespace WebApplication3.DBContext
{
    public class pushJob
    {


        [Key]
        public int Id { get; set; }

        public string ?Description { get; set; }

        public string Pre_title { get; set; }

        public string Title { get; set; }

       
        public string Requrment { get; set; }
        public string Place { get; set; }
        public string Email { get; set; }

        public int Job_Deadline { get; set; }

        public int  companyid { get; set; }
        public Company? company { get; set; }



      [IgnoreDataMember]
       public ICollection<applyJob>? applyJobs { get; set; }



    }
}
