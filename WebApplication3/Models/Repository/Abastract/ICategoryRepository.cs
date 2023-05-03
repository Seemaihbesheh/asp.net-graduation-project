



namespace WebApplication3.Repository.Abastract
{
    public interface ICategoryRepository
    {
        //company
        bool AddUpdate(Company category);
        bool AddUpdateaddmiinn(Admin category);


        //user
        bool AddUpdateuser(userU category);


        bool Delete(int id);
        Company GetById(int id);

      Admin GetByIdadmiiiin(int id);

        IEnumerable<Company> GetAll();

         
         Admin GetadminById(int id);

        userU GetuserById(int id);

     

    }
}
