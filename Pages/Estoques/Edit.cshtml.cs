using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorSegundoProjeto.Data;

namespace RazorSegundoProjeto.Pages.Estoques
{
    public class EditModel : PageModel
    {
        private readonly RazorSegundoProjeto.Data.RazorSegundoProjetoContext _context;

        public EditModel(RazorSegundoProjeto.Data.RazorSegundoProjetoContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Estoques).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstoquesExists(Estoques.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EstoquesExists(int id)
        {
            return _context.Estoques.Any(e => e.ID == id);
        }
    }
}
