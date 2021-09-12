using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CadastroDeFornecedoresApi.Data;
using CadastroDeFornecedoresApi.Models;
using CadastroDeFornecedoresApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeFornecedoresApi.Repositories
{

    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ApplicationDbContext dbContext) 
            : base(dbContext)
        {
        }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await DbContext.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }

    }
}