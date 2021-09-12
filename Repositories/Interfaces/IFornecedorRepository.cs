using System;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Models;

namespace CadastroDeFornecedoresApi.Repositories.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

    }
}