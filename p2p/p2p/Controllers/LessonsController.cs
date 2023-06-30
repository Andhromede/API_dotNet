using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using p2p.Models;
using p2pAPI.Models;

namespace p2p.Controllers
{
    [Route("api/lesson")]
    [ApiController]
    public class LessonsController : ControllerBase
    {
        private readonly P2PContext _context;

        public LessonsController(P2PContext context)
        {
            _context = context;
        }

        // GET: api/Lessons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lesson>>> GetLesson()
        {
          if (_context.Lesson == null)
          {
              return NotFound();
          }
            return await _context.Lesson.ToListAsync();
        }

        // GET: api/Lessons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lesson>> GetLesson(int id)
        {
          if (_context.Lesson == null)
          {
              return NotFound();
          }
            var lesson = await _context.Lesson.FindAsync(id);

            if (lesson == null)
            {
                return NotFound();
            }

            return lesson;
        }

        // PUT: api/Lessons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLesson(int id, Lesson lesson)
        {
            if (id != lesson.id)
            {
                return BadRequest();
            }

            _context.Entry(lesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(id))
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

        // POST: api/Lessons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Lesson>> PostLesson(Lesson lesson)
        {
            _context.Lesson.Add(lesson);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLesson), new { id = lesson.id }, lesson);
        }

        private bool LessonExists(int id)
        {
            return (_context.Lesson?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
