
using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscaPorNome(string Nome);
    }
}
