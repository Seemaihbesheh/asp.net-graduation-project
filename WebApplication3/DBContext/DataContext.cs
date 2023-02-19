

using Microsoft.EntityFrameworkCore;


namespace WebApplication3.DBContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {
        
        }
        public DbSet<User> User { get; set; }
    }
}
