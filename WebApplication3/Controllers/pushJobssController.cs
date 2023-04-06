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
 

    [ApiController]

    [Route("pushJobss")]

    [Produces("application/json")]

    public class pushJobssController : ControllerBase
    {
        private readonly DataContext _context;

        public pushJobssController(DataContext context)
        {
            _context = context;
        }

        // GET: api/pushJobss
        [HttpGet]
        public async Task<ActionResult<IEnumerable<pushJob>>> GetpushJobs()
        {
          if (_context.pushJobs == null)
          {
              return NotFound();
          }
            return await _context.pushJobs.ToListAsync();
        }

        // GET: api/pushJobss/5
        [HttpGet("{id}")]
        public async Task<ActionResult<pushJob>> GetpushJob(int id)
        {
          if (_context.pushJobs == null)
          {
              return NotFound();
          }
            var pushJob = await _context.pushJobs.FindAsync(id);

            if (pushJob == null)
            {
                return NotFound();
            }

            return pushJob;
        }

        // PUT: api/pushJobss/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutpushJob(int id, pushJob pushJob)
        {
            if (id != pushJob.Id)
            {
                return BadRequest();
            }

            _context.Entry(pushJob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pushJobExists(id))
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

        // POST: api/pushJobss
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<pushJob>> PostpushJob(pushJob pushJob)
        {
          if (_context.pushJobs == null)
          {
              return Problem("Entity set 'DataContext.pushJobs'  is null.");
          }
            _context.pushJobs.Add(pushJob);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetpushJob", new { id = pushJob.Id }, pushJob);
        }

        // DELETE: api/pushJobss/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletepushJob(int id)
        {
            if (_context.pushJobs == null)
            {
                return NotFound();
            }
            var pushJob = await _context.pushJobs.FindAsync(id);
            if (pushJob == null)
            {
                return NotFound();
            }

            _context.pushJobs.Remove(pushJob);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool pushJobExists(int id)
        {
            return (_context.pushJobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
