using DesafioApiCompras.Data;
using DesafioApiCompras.Model;
using DesafioApiCompras.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioApiCompras.Services
{
    public class ProdutoService : IProdutoService
    {
        private ProdutoContexto _context;
        public ProdutoService(ProdutoContexto context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto FindById(int id)
        {
            return _context.Produtos.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Produto Create(Produto produto)
        {
            try
            {
                _context.Add(produto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            return produto;
        }

        public void Delete(int id)
        {
           var result = _context.Produtos.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Produtos.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
