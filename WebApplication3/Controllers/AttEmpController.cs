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



        [HttpGet("Search/{id}")]

        public async Task<IActionResult>Search(int id)

        {

            var data = _context.User.Where(x=>x.Id==id).ToList();

            return Ok(data);
            

        }





    }

}


















