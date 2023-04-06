using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
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


          }*/


        [HttpGet]

                public async Task<IActionResult> Search()

                {

                    var data = _context.Genders.ToList();

                    return Ok(data);


                }

        /*    [HttpPost]
            public IActionResult SubmitForm(string myVariable)
            {

                database.save(myVariable);
                // Do something with myVariable
                return Ok();
            }

            */
        [HttpGet("Getuniversity")]
        public async Task<IActionResult> GetUniversity()
        {
            try
            {
                var data = _context.Universitys.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
       


        [HttpGet("Gender")]
        public async Task<IActionResult> GetGender()
        {
            try
            {
                var data = _context.Genders.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public IActionResult PostData([FromBody] student data)
        {
            try
            {
                // Add the received data to the database
                _context.students.Add(data);
                
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












        /////
        ///

        public async Task<InvoiceHeader> GetAllInvoiceHeaderbyCode(string invoiceno)
        {
            var _data = await this._context.TblSalesHeaders.FirstOrDefaultAsync(item => item.InvoiceNo == invoiceno);
            
            return new InvoiceHeader();
        }






        [HttpGet("Getcompany")]
        public async Task<IActionResult> GetCompany()
        {
            try
            {
                var data = _context.Companys.ToList();

                return Ok(data);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }




        // GET: api/Companyy/5
        [HttpGet("getcopmanyID/{id}")]
        public async Task<ActionResult<Company>> Getcompanyid(int id)
        {
            if (_context.Companys == null)
            {
                return NotFound();
            }
            var Companyy = await _context.Companys.FindAsync(id);

            if (Companyy == null)
            {
                return NotFound();
            }

            return Companyy;
        }


        // GET: api/Companyy/5
        [HttpGet("getuserID/{id}")]
        public async Task<ActionResult<userU>> Getuserid(int id)
        {
            if (_context.userUs == null)
            {
                return NotFound();
            }
            var userUss = await _context.userUs.FindAsync(id);

            if (userUss == null)
            {
                return NotFound();
            }

            return userUss;
        }






        /*
         [HttpPut("putcopmanyINFO/{id}")]

         public async Task<IActionResult> Putcompany_info(int id, Company Company)
         {
             if (id != Company.id)
             {
                 return BadRequest();
             }

             _context.Entry(Company).State = EntityState.Modified;


                 await _context.SaveChangesAsync();


             return NoContent();
         }



         */

    }

}


















