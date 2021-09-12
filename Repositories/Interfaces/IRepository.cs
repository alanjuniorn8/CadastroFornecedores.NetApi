using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CadastroFornecedores.Models;

namespace CadastroFornecedores.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {

        //Task return void
        Task Adicionar(TEntity entity);
        
        //Task return TEntity
        Task<TEntity> ObterPorId(Guid id);

        //Task return List of TEntity
        Task<List<TEntity>> ObterTodos();

        Task Atualizar(TEntity entity);

        Task Remover(Guid id);

        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);

        Task<int> SaveChanges();

    }
}