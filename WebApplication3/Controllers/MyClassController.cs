using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
     [Route("myclass")]


        [ApiController]
    public class MyClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }





    }
}
