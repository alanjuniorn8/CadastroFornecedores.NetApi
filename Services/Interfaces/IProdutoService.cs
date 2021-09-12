using CadastroFornecedores.Models;
using System;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);

        Task Atualizar(Produto produto);

        Task Remover(Guid id);

    }
}