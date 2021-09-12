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