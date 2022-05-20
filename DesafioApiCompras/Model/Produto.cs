using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApiCompras.Model
{
    public class Produto
    {
        public long Id { get; set; }
        public string nome { get; set; }
        public decimal valor_unitario { get; set; }
        public int qtde_estoque { get; set; }
        public DateTime? data_ultimavenda { get; set; }
        public decimal? valor_ultimavenda { get; set; }
    }
}
