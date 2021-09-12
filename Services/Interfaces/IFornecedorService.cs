using CadastroFornecedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroFornecedores.Services.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task<bool> Adicionar(Fornecedor fornecedor);

        Task<bool> Atualizar(Fornecedor fornecedor);
        
        Task AtualizarEndereco(Endereco endereco);

        Task<bool> Remover(Guid id);

    }
}
