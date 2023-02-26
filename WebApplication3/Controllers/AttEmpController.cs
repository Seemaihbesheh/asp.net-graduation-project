using Microsoft.AspNetCore.Mvc;
using WebApplication3.DBContext;

namespace WebApplication3.Controllers
{


    [ApiController]

    [Route("AttEmp")]

    [Produces("application/json")]

    public class AttEmpController : ControllerBase

    {

        private readonly DataContext _context;



        public AttEmpController(DataContext context)

        {

            _context = context;

        }


        //[HttpPost("Search}")]

        /*  public async Task<IActionResult> Search()

          {

              var data = _context.Users.ToList();

              return Ok(data);


          }
        */


        [HttpGet("Search/{id}")]

        public async Task<IActionResult> Search(int id)

        {

            //var data = _context.Users.Where(x=>x.User_idAccount == id).ToList();
            var data = from t1 in _context.Companys
                       join t2 in _context.CompanyAccounts on t1.id equals t2.Company_idAccount
                       select t1.Email;

            //Console.WriteLine(data);
            return Ok(data);


        }




    }

}


















