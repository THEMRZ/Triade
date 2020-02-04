using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
