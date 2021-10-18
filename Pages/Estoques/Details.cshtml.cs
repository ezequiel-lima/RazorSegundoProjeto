using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorSegundoProjeto.Data;

namespace RazorSegundoProjeto.Pages.Estoques
{
    public class DetailsModel : PageModel
    {
        private readonly RazorSegundoProjeto.Data.RazorSegundoProjetoContext _context;

        public DetailsModel(RazorSegundoProjeto.Data.RazorSegundoProjetoContext context)
        {
            _context = context;
        }

        public Estoques Estoques { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estoques = await _context.Estoques.FirstOrDefaultAsync(m => m.ID == id);

            if (Estoques == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
