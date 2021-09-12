using System;
using System.Threading.Tasks;
using CadastroFornecedores.Data;
using CadastroFornecedores.Models;
using CadastroFornecedores.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores.Repositories
{

    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ApplicationDbContext dbContext) 
            : base(dbContext)
        {
        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await DbContext.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await DbContext.Fornecedores.AsNoTracking()
                .Include(f => f.Produtos)
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}