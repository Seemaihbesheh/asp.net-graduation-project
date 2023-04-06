using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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