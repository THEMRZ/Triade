using Aplicacao.Interface;
using Dominio.Entidades;
using Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;


namespace Aplicacao
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
                : base (produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
        https://youtu.be/i9Il79a2uBU?t=8533
    }
}
