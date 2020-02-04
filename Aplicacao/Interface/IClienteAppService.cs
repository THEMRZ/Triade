using Dominio.Entidades;
using System.Collections.Generic;

namespace Aplicacao.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
