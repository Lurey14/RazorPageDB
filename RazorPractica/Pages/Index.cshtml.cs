using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPractica.Data;
using RazorPractica.Models;

namespace RazorPractica.Pages
{
    public class IndexModel : PageModel
    {
        private readonly RazorPractica.Data.TareaDbContext _context;

        public IndexModel(RazorPractica.Data.TareaDbContext context)
        {
            _context = context;
        }

        public IList<Tarea> Tarea { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tarea = await _context.Tareas.ToListAsync();
        }
    }
}
