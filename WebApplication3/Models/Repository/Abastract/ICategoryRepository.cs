



namespace WebApplication3.Repository.Abastract
{
    public interface ICategoryRepository
    {
        //company
        bool AddUpdate(Company category);

        //user
        bool AddUpdateuser(userU category);


        bool Delete(int id);
        Company GetById(int id);
        IEnumerable<Company> GetAll();

        
        userU GetuserById(int id);

    }
}
