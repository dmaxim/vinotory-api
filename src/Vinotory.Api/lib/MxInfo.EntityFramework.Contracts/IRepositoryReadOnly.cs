using System.Linq.Expressions;

namespace MxInfo.EntityFramework.Contracts;

public interface IRepositoryReadOnly<TEntity> where TEntity : class
{
    IQueryable<TEntity> GetAll();

    IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);

    Task<IList<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate);

    void Reload(TEntity entity);

    TEntity? FindSingle(Expression<Func<TEntity, bool>> predicate);

    Task<TEntity?> FindSingleAsync(Expression<Func<TEntity, bool>> predicate);

}