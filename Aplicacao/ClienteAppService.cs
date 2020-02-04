using Dominio.Entidades;
using Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
                : base(clienteService)
        {
            _clienteService = clienteService;
        }
        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> cliente)
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
