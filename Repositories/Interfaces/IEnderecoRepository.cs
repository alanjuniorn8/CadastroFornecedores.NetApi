using System;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Models;

namespace CadastroDeFornecedoresApi.Repositories.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}