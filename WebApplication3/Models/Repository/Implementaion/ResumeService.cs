
using WebApplication3.Models.Repository.Abastract;

using Microsoft.AspNetCore.Hosting;

namespace WebApplication3.Models.Repository.Implementaion
{
    public class ResumeService //: IResumeService
    {

        /*
        private readonly DataContext _context;

        public ResumeService(DataContext context)
        {
            this._context = context;
        }



        public async Task store(UploadResume upload_res)
        {
            var userName = await _context.userUs.Where(useru => useru.Id == upload_res.Userid)
                                                      .Select(u => u.UserName).FirstOrDefaultAsync();
            if (userName == null)
            {
                // throw new Exception("username does not exist ");
                throw new ArgumentNullException("userName cannot be null");

            }


            var stream = new MemoryStream();

            upload_res.file.CopyTo(stream);
            var data = stream.ToArray();
            var resume = new Resume()
            {
                ResumeFileName = $"{userName}.pdf",
                FileData = data,
                userid = upload_res.Userid
            };

            await this._context.Resumes.AddAsync(resume);
            var user = await this._context.userUs.Where(user => user.Id == upload_res.Userid)
                   .Select(user => user)
                   .FirstOrDefaultAsync();

            user.Resumes = resume;

            await _context.SaveChangesAsync();

            return;
        }
        */
    }
}
