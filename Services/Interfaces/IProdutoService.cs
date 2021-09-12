using System;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Models;

namespace CadastroDeFornecedoresApi.Services.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);

        Task Atualizar(Produto produto);

        Task Remover(Guid id);

    }
}