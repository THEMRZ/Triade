
using Dominio.Entidades;
using Dominio.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositorios
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscaPorNome(string nome)
        {
            return db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
