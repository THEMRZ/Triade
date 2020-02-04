using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> cliente);
    }
}
