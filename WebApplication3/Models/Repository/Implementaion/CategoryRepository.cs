using WebApplication3.Repository.Abastract;
using WebApplication3.DBContext;
using Microsoft.AspNetCore.Hosting;



namespace WebApplication3.Repository.Implementaion
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _ctx;
        public CategoryRepository(DataContext ctx)
        {
            this._ctx = ctx;
        }
        public bool AddUpdate(Company category)
        {
            try
            {
                if (category.id == 0)
                    _ctx.Companys.Add(category);
                else
                    _ctx.Companys.Update(category);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public bool AddUpdateaddmiinn(Admin category)
        {
            try
            {
                if (category.id == 0)
                    _ctx.Admins.Add(category);
                else
                    _ctx.Admins.Update(category);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }




     


        public bool AddUpdateuser(userU category)
        {
            try
            {
                if (category.Id == 0)
                    _ctx.userUs.Add(category);
                else
                    _ctx.userUs.Update(category);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

       






        public bool Delete(int id)
        {
            try
            {
                var record = GetById(id);
                if (record == null)
                    return false;
                _ctx.Companys.Remove(record);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;

            }
        }
      
        public IEnumerable<Company> GetAll()
        {
            return _ctx.Companys.ToList();
        }

        public Company GetById(int id)
        {
            return _ctx.Companys.Find(id);
        }
        public Admin GetByIdadmiiiin(int id)
        {
            return _ctx.Admins.Find(id);
        }



        public Admin GetadminById(int id)
        {
            return _ctx.Admins.Find(id);
        }


        public userU GetuserById(int id)
        {
            return _ctx.userUs.Find(id);
        }





    }
}
