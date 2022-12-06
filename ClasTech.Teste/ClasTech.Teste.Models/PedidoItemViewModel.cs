using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasTech.Teste.Models
{
    public class PedidoItemViewModel
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> Valor { get; set; }
        public bool Ativo { get; set; }
    }
}
