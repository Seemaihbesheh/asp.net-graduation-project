using WebApplication3.Repository.Abastract;
using WebApplication3.DBContext;

namespace ProductMiniApi.Repository.Implementation
{
    public class ProductRepostory : IProductRepository
    {
        private readonly DataContext _context;
        public ProductRepostory(DataContext context)
        {
            this._context = context;
        }
        public bool AddProduct(Product model)
        {
            try
            {
                _context.Product.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Product.ToList();
        }





        public bool AddApplyJob(applyJob model)
        {
            try
            {
                _context.applyJobs.Add(model);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public IEnumerable<applyJob> GetAllApplyJobs()
        {
            return _context.applyJobs.ToList();
        }


    }
}
