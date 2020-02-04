using Dominio.Entidades;
using Dominio.Interfaces.Repositories;
using Dominio.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Dominio.Servicos
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
                : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscaPorNome(nome);
        }
    }
}
