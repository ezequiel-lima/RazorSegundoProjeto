using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorSegundoProjeto.Pages.Estoques
{
    public class Estoques
    {
        public int ID { get; set; }

        [Display(Name = "Nome do Produto")]
        public string Nome_Produto { get; set; }

        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public float Preco { get; set; }

        [Display(Name = "Data De Entrada")]
        public DateTime dt_Entrada { get; set; }
    }
}
