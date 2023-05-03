using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.DTO;
using WebApplication3.Repository.Abastract;

namespace WebApplication3.Controllers
{

    [ApiController]

    [Route("update")]

    [Produces("application/json")]
    public class update_controler : ControllerBase
    {
        //private readonly DataContext _context;
       
        private readonly ICategoryRepository _categoryRepos;
        public update_controler(ICategoryRepository catRepo)
        {
            _categoryRepos = catRepo;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _categoryRepos.GetAll();
            return Ok(data);
        }

        [HttpGet("getcopmanyprofileid/{id}")]
        public IActionResult GetById(int id)
        {
            var data = _categoryRepos.GetById(id);
            return Ok(data);
        }


        [HttpGet("getadmiiinnprofileid/{id}")]
        public IActionResult GetByIdadmiiiin(int id)
        {
            var data = _categoryRepos.GetByIdadmiiiin(id);
            return Ok(data);
        }




        [HttpGet("getadminprofileid/{id}")]
        public IActionResult GetadminById(int id)
        {
            var data = _categoryRepos.GetById(id);
            return Ok(data);
        }



        [HttpGet("getuserprofileid/{id}")]
        public IActionResult GetuserById(int id)
        {
            var data = _categoryRepos.GetuserById(id);
            return Ok(data);
        }




        //for company
        [HttpPost("update")]
        public IActionResult AddUpdate(Company model)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Validatation failed";
            }
            var result = _categoryRepos.AddUpdate(model);

            status.StatusCode = result ? 1 : 0;
            status.Message = result ? "Saved successfully" : "Error has occured";
            return Ok(status);
        }


        
        [HttpPost("updateadmiiin")]
        public IActionResult AddUpdateaddmiinn(Admin model)
        {
            var status = new Status();
            if (!ModelState.IsValid)
            {
                status.StatusCode = 0;
                status.Message = "Validatation failed";
            }
            var result = _categoryRepos.AddUpdateaddmiinn(model);

            status.StatusCode = result ? 1 : 0;
            status.Message = result ? "Saved successfully" : "Error has occured";
            return Ok(status);
        }



        [HttpPost("updateuser")]
        public IActionResult AddUpdateuser(userU model)
        {
           // var status = new Status();
          //  if (!ModelState.IsValid)
          //  {
             //   status.StatusCode = 0;
               // status.Message = "Validatation failed";
          //  }
            var result = _categoryRepos.AddUpdateuser(model);

           // status.StatusCode = result ? 1 : 0;
           // status.Message = result ? "Saved successfully" : "Error has occured";
            return Ok("done");
        }


      


          



        /*
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _categoryRepos.Delete(id);
            var status = new Status
            {
                StatusCode = result ? 1 : 0,
                Message = result ? "deleted successfully" : "Error has occured"
            };
            return Ok(status);
        }
        */
        // }





    }
}
