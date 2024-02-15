using Microsoft.AspNetCore.Mvc;
using WebApplication3.DBContext;

namespace WebApplication3.Controllers
{



    [ApiController]

    [Route("SkillandProject")]

    [Produces("application/json")]
    public class SkillandProject : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly DataContext _context;



        public SkillandProject(DataContext context)

        {

            _context = context;

        }



        [HttpGet("Getskill")]
        public async Task<IActionResult> GetSkill()
        {
            try
            {
                var data = _context.skills.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

      

        [HttpGet("Getproject")]
        public async Task<IActionResult> GetProject()
        {
            try
            {
                var data = _context.projects.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }





        [HttpPost("pushSkill")]
        public IActionResult PostData([FromBody] skill data)
        {
            try
            {
                // Add the received data to the database
                _context.skills.Add(data);

                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully to skill.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }




        [HttpPost("pushProject")]
        public IActionResult PostData([FromBody] project data)
        {
            try
            {
                // Add the received data to the database
                _context.projects.Add(data);

                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully to project.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }



        [HttpGet("Getreview")]
        public async Task<IActionResult> Getreview()
        {
            try
            {
                var data = _context.reviews.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost("pushreviews")]
        public IActionResult PostData([FromBody] review data)
        {
            try
            {
                // Add the received data to the database
                _context.reviews.Add(data);

                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully to project.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }

    }
}
