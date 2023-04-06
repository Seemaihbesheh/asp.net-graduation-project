using Microsoft.AspNetCore.Mvc;

using WebApplication3.DBContext;
namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("cvv")]
    [Produces("application/json")]

    public class cvvController : Controller
    {
        private readonly DataContext _context;
        public cvvController(DataContext context)

        {

            _context = context;

        }


        [HttpGet("Getcv")]
        public async Task<IActionResult> GetCv()
        {
            try
            {
                var data = _context.cvs.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPost]
        public IActionResult PostData([FromBody] cv data)
        {
            try
            {
                // Add the received data to the database
                _context.cvs.Add(data);
                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully to  cv done");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }

    }
}

