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
    public class DeleteModel : PageModel
    {
        private readonly RazorSegundoProjeto.Data.RazorSegundoProjetoContext _context;

        public DeleteModel(RazorSegundoProjeto.Data.RazorSegundoProjetoContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Estoques = await _context.Estoques.FindAsync(id);

            if (Estoques != null)
            {
                _context.Estoques.Remove(Estoques);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
