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
    [Route("applyjob")]


    [ApiController]
    public class applyJobsController : ControllerBase
    {
        private readonly DataContext _context;

        public applyJobsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/applyJobs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<applyJob>>> GetapplyJobs()
        {
          if (_context.applyJobs == null)
          {
              return NotFound();
          }
            return await _context.applyJobs.ToListAsync();
        }

        // GET: api/applyJobs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<applyJob>> GetapplyJob(int id)
        {
          if (_context.applyJobs == null)
          {
              return NotFound();
          }
            var applyJob = await _context.applyJobs.FindAsync(id);

            if (applyJob == null)
            {
                return NotFound();
            }

            return applyJob;
        }

        // PUT: api/applyJobs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutapplyJob(int id, applyJob applyJob)
        {
            if (id != applyJob.Id)
            {
                return BadRequest();
            }

            _context.Entry(applyJob).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!applyJobExists(id))
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

        // POST: api/applyJobs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<applyJob>> PostapplyJob(applyJob applyJob)
        {
          if (_context.applyJobs == null)
          {
              return Problem("Entity set 'DataContext.applyJobs'  is null.");
          }
            _context.applyJobs.Add(applyJob);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetapplyJob", new { id = applyJob.Id }, applyJob);
        }

        // DELETE: api/applyJobs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteapplyJob(int id)
        {
            if (_context.applyJobs == null)
            {
                return NotFound();
            }
            var applyJob = await _context.applyJobs.FindAsync(id);
            if (applyJob == null)
            {
                return NotFound();
            }

            _context.applyJobs.Remove(applyJob);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool applyJobExists(int id)
        {
            return (_context.applyJobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
