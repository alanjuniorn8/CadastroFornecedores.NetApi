using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CadastroFornecedores.Data;
using CadastroFornecedores.Models;
using CadastroFornecedores.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroFornecedores.Repositories
{

    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await DbContext.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await DbContext.Produtos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome)
                .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}