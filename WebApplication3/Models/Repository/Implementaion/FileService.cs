using WebApplication3.Repository.Abastract;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication3.Repository.Implementaion
{
    public class FileService : IFileService
    {
        private IWebHostEnvironment environment;
        public FileService(IWebHostEnvironment env)
        {
            this.environment = env;
        }

        public Tuple<int, string> SaveImage(IFormFile imageFile)
        {
            try
            {
                var path = GetFilePath();

                // Check the allowed extenstions
                var ext = Path.GetExtension(imageFile.FileName);
                var allowedExtensions = new string[] { ".jpg", ".png", ".jpeg", ".pdf" };
                if (!allowedExtensions.Contains(ext))
                {
                    string msg = string.Format("Only {0} extensions are allowed", string.Join(",", allowedExtensions));
                    return new Tuple<int, string>(0, msg);
                }
                string uniqueString = Guid.NewGuid().ToString()+"_"+imageFile.FileName;

                // we are trying to create a unique filename here
                var fileWithPath = Path.Combine(path, uniqueString);
                var stream = new FileStream(fileWithPath, FileMode.Create);
                imageFile.CopyTo(stream);
                stream.Close();

                return new Tuple<int, string>(1, uniqueString);
            }
            catch (Exception ex)
            {
                return new Tuple<int, string>(0, "Error has occured");
            }


        }

        public bool DeleteImage(string imageFileName)
        {
            try
            {
                var wwwPath = this.environment.WebRootPath;
                var path = Path.Combine(wwwPath, "applyjobFileUploads", imageFileName);
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetFilePath()
        {
            string wwwPath = this.environment.WebRootPath;

            string path = Path.Combine(wwwPath, "applyjobFileUploads");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }
    }
}
