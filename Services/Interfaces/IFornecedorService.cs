using CadastroDeFornecedoresApi.Models;
using System;
using System.Threading.Tasks;

namespace CadastroDeFornecedoresApi.Services.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task<bool> Adicionar(Fornecedor fornecedor);

        Task<bool> Atualizar(Fornecedor fornecedor);
        
        Task AtualizarEndereco(Endereco endereco);

        Task<bool> Remover(Guid id);

    }
}
