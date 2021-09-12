using System;
using System.Threading.Tasks;
using CadastroFornecedores.Models;

namespace CadastroFornecedores.Repositories.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);

    }
}