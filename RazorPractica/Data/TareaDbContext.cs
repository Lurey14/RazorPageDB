using Microsoft.EntityFrameworkCore;
using RazorPractica.Models;

namespace RazorPractica.Data
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options)
        {

        }
        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContext()
        {

        }
    }
}
