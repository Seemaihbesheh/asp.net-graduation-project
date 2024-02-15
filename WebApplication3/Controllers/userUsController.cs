using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using WebApplication3.DBContext;

namespace WebApplication3.Controllers
{
    [Route("userUs")]
    [ApiController]
    public class userUsController : ControllerBase
    {
        private readonly DataContext _context;

        public userUsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/userUs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<userU>>> GetuserUs()
        {
          if (_context.userUs == null)
          {
              return NotFound();
          }
            return await _context.userUs.ToListAsync();
        }

        // GET: api/userUs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<userU>> GetuserU(int id)
        {
          if (_context.userUs == null)
          {
              return NotFound();
          }
            var userU = await _context.userUs.FindAsync(id);

            if (userU == null)
            {
                return NotFound();
            }

            return userU;
        }

        // PUT: api/userUs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutuserU(int id, userU userU)
        {
            if (id != userU.Id)
            {
                return BadRequest();
            }

            _context.Entry(userU).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!userUExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/userUs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<userU>> PostuserU(userU userU)
        {
          if (_context.userUs == null)
          {
              return Problem("Entity set 'DataContext.userUs'  is null.");
          }
            _context.userUs.Add(userU);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetuserU", new { id = userU.Id }, userU);
        }

        // DELETE: api/userUs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteuserU(int id)
        {
            if (_context.userUs == null)
            {
                return NotFound();
            }
            var userU = await _context.userUs.FindAsync(id);
            if (userU == null)
            {
                return NotFound();
            }

            _context.userUs.Remove(userU);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool userUExists(int id)
        {
            return (_context.userUs?.Any(e => e.Id == id)).GetValueOrDefault();
        }





       


        [HttpGet("GetapplyJob/{searchValue}")]
        public async Task<IActionResult> GetApplyJob(string? searchValue)
        {
            var search = searchValue?.ToLower();
            var data = new List<applyJob>();
            /* try
             {*/
            if (search.IsNullOrEmpty())
            {
                data = _context.applyJobs.Include(x => x.pushJob).ToList();
            }
            else
            {
                data = _context.applyJobs.Where(t =>
                t.Full_Name.ToLower().Contains(search) ||
                t.Email.ToLower().Contains(search) ||
                t.City.ToLower().Contains(search) ||
               (t.FileDisplayName != null && t.FileDisplayName.ToLower().Contains(search))
              )

    .Include(x => x.pushJob).ToList();

            }

            // var path = GetFilePath();
            var baseUri = $"{Request.Scheme}://{Request.Host}";

            data.ForEach(t => t.ProductImage = Path.Combine(baseUri, "applyJobFileUploads", t.ProductImage));

            return Ok(data);
            //}

            /*   catch (Exception ex)
               {
                   throw ex;
               }*/
        }








    }
}






/*
// GET: api/userUs
[HttpGet]
public async Task<ActionResult<IEnumerable<userU>>> GetuserUs()
{
    if (_context.userUs == null)
    {
        return NotFound();
    }
    return await _context.userUs.ToListAsync();
}



[HttpGet]

public async Task<IActionResult> Search()

{

    var data = _context.Genders.ToList();

    return Ok(data);


}
*/