using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorSegundoProjeto.Pages.Funcionarios;
using RazorSegundoProjeto.Pages.Estoques;

namespace RazorSegundoProjeto.Data
{
    public class RazorSegundoProjetoContext : DbContext
    {
        public RazorSegundoProjetoContext (DbContextOptions<RazorSegundoProjetoContext> options)
            : base(options)
        {
        }

        public DbSet<RazorSegundoProjeto.Pages.Funcionarios.Funcionario> Funcionario { get; set; }

        public DbSet<RazorSegundoProjeto.Pages.Estoques.Estoques> Estoques { get; set; }
    }
}
