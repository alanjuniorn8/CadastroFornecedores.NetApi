using CadastroDeFornecedoresApi.Models;
using CadastroDeFornecedoresApi.Notificacoes;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using CadastroDeFornecedoresApi.Services.Interfaces;
using CadastroDeFornecedoresApi.Validators;
using System;
using System.Threading.Tasks;

namespace CadastroDeFornecedoresApi.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Adicionar(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidator(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {

            await _produtoRepository.Remover(id);

        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }

    }
}
