using Microsoft.EntityFrameworkCore;
using FutureSkillHub.Api.Models;

namespace FutureSkillHub.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos => Set<Curso>();
    }
}

