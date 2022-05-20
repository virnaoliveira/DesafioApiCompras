using DesafioApiCompras.Model;
using System.Collections.Generic;

namespace DesafioApiCompras.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto Create(Produto produto);
        Produto FindById(int id);
        List<Produto> FindAll();
        void Delete(int id);
    }
}
