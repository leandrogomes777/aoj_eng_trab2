using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlarmService.Model;
using AlarmService.Models;

namespace AlarmService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlarmsController : ControllerBase
    {
        private readonly AlarmServiceContext _context;

        public AlarmsController(AlarmServiceContext context)
        {
            _context = context;
        }

        // GET: api/Alarms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Alarm>>> GetAlarm()
        {
            return await _context.Alarm.ToListAsync();
        }

        // GET: api/Alarms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Alarm>> GetAlarm(long id)
        {
            var alarm = await _context.Alarm.FindAsync(id);

            if (alarm == null)
            {
                return NotFound();
            }

            return alarm;
        }

        // PUT: api/Alarms/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlarm(long id, Alarm alarm)
        {
            if (id != alarm.AlarmId)
            {
                return BadRequest();
            }

            _context.Entry(alarm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlarmExists(id))
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

        // POST: api/Alarms
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Alarm>> PostAlarm(Alarm alarm)
        {
            _context.Alarm.Add(alarm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlarm", new { id = alarm.AlarmId }, alarm);
        }

        // DELETE: api/Alarms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Alarm>> DeleteAlarm(long id)
        {
            var alarm = await _context.Alarm.FindAsync(id);
            if (alarm == null)
            {
                return NotFound();
            }

            _context.Alarm.Remove(alarm);
            await _context.SaveChangesAsync();

            return alarm;
        }

        private bool AlarmExists(long id)
        {
            return _context.Alarm.Any(e => e.AlarmId == id);
        }
    }
}
