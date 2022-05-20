using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApiCompras.Model
{
    public class Compra
    {
        public int id { get; set; }
        public int produto_id { get; set; }
        public int qtde_comprada { get; set; }
        public Cartao cartao { get; set; } 
    }
}
