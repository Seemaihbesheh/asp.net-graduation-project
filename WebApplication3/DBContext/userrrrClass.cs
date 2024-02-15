using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace WebApplication3.DBContext
{
    public class userrrrClass
    {

        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
