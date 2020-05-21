using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DrugsService.Model;
using DrugsService.Models;

namespace DrugsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrugsController : ControllerBase
    {
        private readonly DrugsContext _context;

        public DrugsController(DrugsContext context)
        {
            _context = context;
        }

        // GET: api/Drugs1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Drug>>> GetDrug()
        {
            return await _context.Drug.ToListAsync();
        }

        // GET: api/Drugs1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Drug>> GetDrug(long id)
        {
            var drug = await _context.Drug.FindAsync(id);

            if (drug == null)
            {
                return NotFound();
            }

            return drug;
        }

        // PUT: api/Drugs1/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDrug(long id, Drug drug)
        {
            if (id != drug.ID)
            {
                return BadRequest();
            }

            _context.Entry(drug).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DrugExists(id))
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

        // POST: api/Drugs1
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Drug>> PostDrug(Drug drug)
        {
            _context.Drug.Add(drug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDrug", new { id = drug.ID }, drug);
        }

        // DELETE: api/Drugs1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Drug>> DeleteDrug(long id)
        {
            var drug = await _context.Drug.FindAsync(id);
            if (drug == null)
            {
                return NotFound();
            }

            _context.Drug.Remove(drug);
            await _context.SaveChangesAsync();

            return drug;
        }

        private bool DrugExists(long id)
        {
            return _context.Drug.Any(e => e.ID == id);
        }
    }
}
