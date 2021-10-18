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
    public class IndexModel : PageModel
    {
        private readonly RazorSegundoProjeto.Data.RazorSegundoProjetoContext _context;

        public IndexModel(RazorSegundoProjeto.Data.RazorSegundoProjetoContext context)
        {
            _context = context;
        }

        public IList<Estoques> Estoques { get;set; }

        public async Task OnGetAsync()
        {
            Estoques = await _context.Estoques.ToListAsync();
        }
    }
}
