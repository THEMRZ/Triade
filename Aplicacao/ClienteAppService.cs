using Aplicacao.Interface;
using Dominio.Entidades;
using Dominio.Interfaces.Services;
using System.Collections.Generic;


namespace Aplicacao
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
                : base(clienteService)
        {
            _clienteService = clienteService;
        }      

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
