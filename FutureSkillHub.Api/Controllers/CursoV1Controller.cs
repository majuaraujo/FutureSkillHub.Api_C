using FutureSkillHub.Api.Data;
using FutureSkillHub.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FutureSkillHub.Api.Controllers
{
    [ApiController]
    [Route("api/v1/cursos")]
    public class CursoV1Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public CursoV1Controller(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get() =>
            Ok(await _context.Cursos.ToListAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            return curso == null ? NotFound() : Ok(curso);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Curso curso)
        {
            _context.Cursos.Add(curso);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = curso.Id }, curso);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Curso curso)
        {
            if (id != curso.Id) return BadRequest();

            _context.Entry(curso).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var curso = await _context.Cursos.FindAsync(id);
            if (curso == null) return NotFound();

            _context.Cursos.Remove(curso);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
