using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApiCompras.Model
{
    public class Cartao
    {
        public int Id { get; set; }
        public string titular { get; set; }
        public string numero { get; set; }
        public DateTime data_expiracao { get; set; }
        public string bandeira { get; set; }
        public string cvv { get; set; }
    }
}
