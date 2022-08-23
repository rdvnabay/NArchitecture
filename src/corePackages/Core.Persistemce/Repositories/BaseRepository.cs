using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace Core.Persistemce.Repositories;

public class BaseRepository<TContext, TEntity> : IAsyncRepository<TEntity>
    where TContext : DbContext
    where TEntity : class
{
    protected TContext _context;
    public BaseRepository(TContext context)
    {
        _context = context;
    }

    //Add-Update-Delete
    public async Task<TEntity> AddAsync(TEntity entity)
    {
        _context.Entry(entity).State = EntityState.Added;
        await _context.SaveChangesAsync();
        return entity;
    }

    //Get
    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> query)
    {
        throw new NotImplementedException();
    }

    //Query
    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> query) =>
        await _context.Set<TEntity>().AnyAsync(query);
}
