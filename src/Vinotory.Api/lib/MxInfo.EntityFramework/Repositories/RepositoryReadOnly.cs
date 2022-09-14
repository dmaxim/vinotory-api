using System.Linq.Expressions;
using MxInfo.EntityFramework.Contracts;
using Microsoft.EntityFrameworkCore;
using MxInfo.Library.ExceptionHandling;

namespace MxInfo.EntityFramework.Repositories;

public abstract class RepositoryReadOnly<TEntity> : IRepositoryReadOnly<TEntity>  where TEntity : class
{
    private readonly IEntityContext _entityContext;

    protected RepositoryReadOnly(IEntityContext entityContext)
    {
        _entityContext = entityContext;
    }

    protected DbContext Context => _entityContext.Context;

    public IQueryable<TEntity> GetAll()
    {
        return Context.Set<TEntity>();
    }

    public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
    {
        return Context.Set<TEntity>().Where(predicate);
    }

    public async Task<IList<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await Context.Set<TEntity>().Where(predicate).ToListAsync();
    }

    public void Reload(TEntity entity)
    {
        Context.Entry(entity).Reload();
    }

    public TEntity? FindSingle(Expression<Func<TEntity, bool>> predicate)
    {
        var entities = FindBy(predicate).ToList();
        AssertSingle(entities);
        return entities.FirstOrDefault();
    }

    public async Task<TEntity?> FindSingleAsync(Expression<Func<TEntity, bool>> predicate)
    {
        var entities = await FindByAsync(predicate);
        AssertSingle(entities);
        return entities.FirstOrDefault();
    }


    private static void AssertSingle(IList<TEntity> entities)
    {
        if (entities.Count > 1)
        {
            throw new MxInfoMultipleFoundException(
                $"More than one {(typeof(TEntity).Name)} was found matching the filter criteria.");
        }
    }
}

