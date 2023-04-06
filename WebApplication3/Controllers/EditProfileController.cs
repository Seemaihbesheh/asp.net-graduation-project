using Microsoft.AspNetCore.Mvc;
using WebApplication3.DBContext;

namespace WebApplication3.Controllers
{


    [ApiController]

    [Route("EditProfile")]

    

    public class EditProfileController : Controller
    {

        private readonly DataContext _context;

        public EditProfileController(DataContext context)
        {
            _context = context;
        }



        [HttpPost]
        public IActionResult PostData([FromBody] UserAccount data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Add the received data to the database
                _context.UserAccounts.Add(data);
                _context.SaveChanges();

                // Return a success response
                return Ok("Data added successfully.");
            }
            catch (Exception ex)
            {
                // Return an error response
                return BadRequest("Error: " + ex.Message);
            }
        }

    }
}

