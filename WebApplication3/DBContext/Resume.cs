using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.DBContext
{


    [Table("Resume")]
    public class Resume
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ResumeFileName { get; set; }
        public byte[] FileData { get; set; }


        public int userid { get; set; }

    }
}
