using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.Repository.Abastract;

namespace WebApplication3.Controllers
{
    /*
    [ApiController]

    [Route("Resume")]

    [Produces("application/json")]
    public class ResumeController : Controller
    {
       

        private readonly IResumeService _resumeService;
        public ResumeController (IResumeService _res)
        {

            _resumeService = _res?? throw new ArgumentException("Parameter cannot be null", nameof(IResumeService));

            

        }
        [HttpPost]
        
        public async Task<IActionResult> uploadResume([FromBody] UploadResume upload_res)
        {
            if(upload_res.Userid == null || upload_res.file == null)
            {
                return BadRequest();
            }
            try
            {
               await _resumeService.store(upload_res);
                return Ok("Data done successfully in fileeeee.");
            }
            catch (ArgumentNullException ex)
            {
                return Unauthorized();
            }


        }

    }
    */
}
