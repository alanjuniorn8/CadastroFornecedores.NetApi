using System;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Data;
using CadastroDeFornecedoresApi.Models;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeFornecedoresApi.Repositories
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