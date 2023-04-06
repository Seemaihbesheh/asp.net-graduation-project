namespace WebApplication3.Repository.Abastract
{
    public interface IFileService
    {
        public Tuple<int, string> SaveImage(IFormFile imageFile);
        public bool DeleteImage(string imageFileName);
    }
}
