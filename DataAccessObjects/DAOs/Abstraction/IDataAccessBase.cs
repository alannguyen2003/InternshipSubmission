using System.Linq.Expressions;

namespace DataAccessObjects.DAOs.Abstraction;

public interface IDataAccessBase<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "",
        int? pageIndex = null,
        int? pageSize = null);

    Task<TEntity?> GetById(object id);

    Task Insert(TEntity entity);

    Task Delete(object? id);

    Task Delete(TEntity? entity);

    Task Update(TEntity entity);
}