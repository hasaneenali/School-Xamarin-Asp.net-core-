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
    public class MaterialsController : ControllerBase
    {
        private readonly DataContext _context;

        public MaterialsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Materials
        [HttpGet]
        public IEnumerable<Material> GetMaterials()
        {
            return _context.Materials;
        }

        // GET: api/Materials/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMaterial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var material = await _context.Materials.FindAsync(id);

            if (material == null)
            {
                return NotFound();
            }

            return Ok(material);
        }

        // PUT: api/Materials/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMaterial([FromRoute] int id, [FromBody] Material material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != material.Id)
            {
                return BadRequest();
            }

            _context.Entry(material).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaterialExists(id))
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

        // POST: api/Materials
        [HttpPost]
        [Route("AddMaterial")]
        public async Task<IActionResult> AddMaterial([FromBody] List<Material> material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Materials.AddRange(material);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMaterial", material);
           // return CreatedAtAction("GetMaterial", new { id = material.Id }, material);
        }

        [HttpPost]
        public async Task<IActionResult> PostMaterial([FromBody] Material material)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Materials.Add(material);
            await _context.SaveChangesAsync();

           
             return CreatedAtAction("GetMaterial", new { id = material.Id }, material);
        }

        // DELETE: api/Materials/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMaterial([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var material = await _context.Materials.FindAsync(id);
            if (material == null)
            {
                return NotFound();
            }

            _context.Materials.Remove(material);
            await _context.SaveChangesAsync();

            return Ok(material);
        }

        private bool MaterialExists(int id)
        {
            return _context.Materials.Any(e => e.Id == id);
        }
    }
}