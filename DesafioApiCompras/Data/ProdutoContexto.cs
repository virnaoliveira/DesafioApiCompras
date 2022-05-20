using DesafioApiCompras.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApiCompras.Data
{
    public class ProdutoContexto : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Password=#jamsoftsistemas1310;Persist Security Info=True;User ID=sa;Initial Catalog=ApiCompras;Data Source=localhost\\sistemas");
        }
    }
}
