/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;*/
using p2p.Helpers;
using p2p.Models;
using p2pAPI.Models;
/*using static p2pAPI.Helpers.DtoRecordsHelpers;*/

namespace p2p.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly P2PContext _context;

        public PersonsController(P2PContext context)
        {
            _context = context;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetPerson()
        {
          if (_context.Person == null)
          {
              return NotFound();
          }
            return await _context.Person.ToListAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Person>> GetPerson(int id)
        {
          if (_context.Person == null)
          {
              return NotFound();
          }
            var person = await _context.Person.FindAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return person;
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerson(int id, Person person)
        {
            if (id != person.id)
            {
                return BadRequest();
            }

            _context.Entry(person).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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






        // POST: api/Person
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(PersonDto.create personDto)
        {
            var role = _context.Role.FirstOrDefault(item => item.Id == personDto.roleId);
            Console.Writline(role);

            Person person = new Person
            {
                id = personDto.id,
                firstName = personDto.firstName,
                lastName = personDto.lastName,
                email = personDto.email,
                password = personDto.password,
                adress = personDto.adress,
                birthday = personDto.birthday,
                role = role,
                isActive = true,
            };

            /*_context.SaveChanges();*/
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPerson), new { id = personDto.id }, personDto);
        }






        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            if (_context.Person == null)
            {
                return NotFound();
            }
            var person = await _context.Person.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            _context.Person.Remove(person);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonExists(int id)
        {
            return (_context.Person?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
