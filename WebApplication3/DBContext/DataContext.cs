

using Microsoft.EntityFrameworkCore;


namespace WebApplication3.DBContext
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }


        // MessageDto
        public DbSet<MessageDto> MessageDtos { get; set; }











        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Cv_Creat> Cv_Creats { get; set; }

        public DbSet<CV_upload> CV_uploads { get; set; }

    //   public DbSet<CompanyAccount> CompanyAccounts { get; set; }

        public DbSet<Company> Companys { get; set; }

        public DbSet<image_post> image_posts { get; set; }
        
        public DbSet<notifications> notificationss { get; set; }

        public DbSet<Comment> Comments { get; set; }
       
        public DbSet<Gender> Genders { get; set; }
        public DbSet<University> Universitys { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<pushJob> pushJobs { get; set; }
        public DbSet<applyJob> applyJobs { get; set; }
        public DbSet<cv> cvs { get; set; }
    
        public DbSet<userU> userUs { get; set; }
        public  DbSet<TblSalesHeader> TblSalesHeaders { get; set; } = null!;


        public DbSet<Product> Product { get; set; }

        
          public DbSet<Resume> Resumes { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
}



