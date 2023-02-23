

using Microsoft.EntityFrameworkCore;


namespace WebApplication3.DBContext
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Cv_Creat> Cv_Creats { get; set; }

        public DbSet<CV_upload> CV_uploads { get; set; }

        public DbSet<CompanyAccount> CompanyAccounts { get; set; }

        public DbSet<Company> Companys { get; set; }
        public DbSet<image_post> image_posts { get; set; }
        
        public DbSet<notifications> notificationss { get; set; }
    }
}
