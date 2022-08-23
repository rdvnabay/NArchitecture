using System.Linq.Expressions;
namespace Core.Persistemce.Repositories;

public interface IAsyncRepository<T> where T : class
{
    Task<T> GetAsync(Expression<Func<T, bool>> query);
    Task<bool> AnyAsync(Expression<Func<T, bool>> query);
    Task<T> AddAsync(T entity);
}
