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
    [Route("api/chapter")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly P2PContext _context;

        public ChaptersController(P2PContext context)
        {
            _context = context;
        }

        // GET: api/Chapters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Chapter>>> GetChapter()
        {
          if (_context.Chapter == null)
          {
              return NotFound();
          }
            return await _context.Chapter.ToListAsync();
        }


        // GET: api/Chapters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chapter>> GetChapter(int id)
        {
          if (_context.Chapter == null)
          {
              return NotFound();
          }
            var chapter = await _context.Chapter.FindAsync(id);

            if (chapter == null)
            {
                return NotFound();
            }

            return chapter;
        }


        // PUT: api/Chapters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Chapter>> PutChapter(int id, Chapter chapter)

        {
            //if (id != chapter.id)
            //{
            //    return BadRequest();
            //}

            _context.Entry(chapter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChapterExists(id))
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


        // POST: api/Chapters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Chapter>> PostChapter(Chapter chapter)
        {
            _context.Chapter.Add(chapter);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetChapter), new { id = chapter.id }, chapter);
        }


        // DELETE: api/Chapters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter(int id)
        {
            if (_context.Chapter == null)
            {
                return NotFound();
            }
            var chapter = await _context.Chapter.FindAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }

            _context.Chapter.Remove(chapter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChapterExists(int id)
        {
            return (_context.Chapter?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
