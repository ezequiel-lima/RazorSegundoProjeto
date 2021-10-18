using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorSegundoProjeto.Data;

namespace RazorSegundoProjeto.Pages.Estoques
{
    public class CreateModel : PageModel
    {
        private readonly RazorSegundoProjeto.Data.RazorSegundoProjetoContext _context;

        public CreateModel(RazorSegundoProjeto.Data.RazorSegundoProjetoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estoques Estoques { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Estoques.Add(Estoques);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
