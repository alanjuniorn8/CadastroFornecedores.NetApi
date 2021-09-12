using System;
using System.Threading.Tasks;
using CadastroFornecedores.Models;

namespace CadastroFornecedores.Repositories.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}