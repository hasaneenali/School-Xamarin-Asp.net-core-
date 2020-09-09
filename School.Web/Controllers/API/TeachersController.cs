using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.Web.Data;
using School.Web.Data.Entities;
using School.Web.Helpers;

namespace School.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly DataContext _context;

        public TeachersController(DataContext context)
        {
            _context = context;
        }


        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacher()
        {
            return await _context.Teacher.Include(m => m.Material).ToListAsync();
        }

       

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeacher([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teacher = await _context.Teacher.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return Ok(teacher);
        }

        // PUT: api/Teachers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher([FromRoute] int id, [FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != teacher.Id)
            {
                return BadRequest();
            }

            var oldPet = await _context.Teacher.FindAsync(teacher.Id);
            if (oldPet == null)
            {
                return BadRequest("teacher doesn't exists.");
            }

            var imageUrl = oldPet.ImageUrl;
            if (teacher.ImageArray != null && teacher.ImageArray.Length > 0)
            {
                var stream = new MemoryStream(teacher.ImageArray);
                var guid = Guid.NewGuid().ToString();
                var file = $"{guid}.jpg";
                var folder = "wwwroot\\images\\Teacher";
                var fullPath = $"~/images/Teacher/{file}";

                var response = FilesHelper.UploadPhoto(stream, folder, file);

                if (response)
                {
                    imageUrl = fullPath;
                }
            }

            oldPet.Name = teacher.Name;
            oldPet.ImageUrl = imageUrl;
            oldPet.Age = teacher.Age;
            oldPet.Mobile = teacher.Mobile;
            oldPet.MaterialId = teacher.MaterialId;
           

            _context.Entry(oldPet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
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

        // POST: api/Teachers
        [HttpPost]
        public async Task<IActionResult> PostTeacher([FromBody] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageUrl = string.Empty;

            if (teacher.ImageArray != null && teacher.ImageArray.Length > 0)
            {
                var stream = new MemoryStream(teacher.ImageArray);
                var guid = Guid.NewGuid().ToString();
                var file = $"{guid}.jpg";
                var folder = "wwwroot\\images\\Teacher";
                var fullPath = $"~/images/Teacher/{file}";
                var response = FilesHelper.UploadPhoto(stream, folder, file);

                if (response)
                {
                    imageUrl = fullPath;
                }
            }

            var teacherAdd = new Teacher
            {
                Name = teacher.Name,
                MaterialId=teacher.MaterialId,
                Age = teacher.Age,
                Mobile = teacher.Mobile,
                ImageUrl = imageUrl
            };

            _context.Teacher.Add(teacherAdd);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacher", new { id = teacher.Id }, teacher);

          

        }

        // DELETE: api/Teachers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeacher([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var teacher = await _context.Teacher.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }

            _context.Teacher.Remove(teacher);
            await _context.SaveChangesAsync();

            return Ok(teacher);
        }

        private bool TeacherExists(int id)
        {
            return _context.Teacher.Any(e => e.Id == id);
        }
    }
}