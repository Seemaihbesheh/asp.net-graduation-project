namespace WebApplication3.Repository.Abastract
{
    public interface IProductRepository
    {
        bool AddProduct(Product model);
        IEnumerable<Product> GetAllProducts();
        bool AddApplyJob(applyJob model);
        IEnumerable<applyJob> GetAllApplyJobs();


    }
}