using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Web.Data;
using School.Web.Data.Entities;

namespace School.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly DataContext _context;

        public ClassesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Classes
        [HttpGet]
        public IEnumerable<Classe> GetClasses()
        {
            return _context.Classes;
        }

        // GET: api/Classes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetClasse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classe = await _context.Classes.FindAsync(id);

            if (classe == null)
            {
                return NotFound();
            }

            return Ok(classe);
        }

        // PUT: api/Classes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClasse([FromRoute] int id, [FromBody] Classe classe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classe.Id)
            {
                return BadRequest();
            }

            _context.Entry(classe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClasseExists(id))
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

        // POST: api/Classes
        [HttpPost]
        public async Task<IActionResult> PostClasse([FromBody] Classe classe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Classes.Add(classe);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClasse", new { id = classe.Id }, classe);
        }

        // DELETE: api/Classes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClasse([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var classe = await _context.Classes.FindAsync(id);
            if (classe == null)
            {
                return NotFound();
            }

            _context.Classes.Remove(classe);
            await _context.SaveChangesAsync();

            return Ok(classe);
        }

        private bool ClasseExists(int id)
        {
            return _context.Classes.Any(e => e.Id == id);
        }
    }
}