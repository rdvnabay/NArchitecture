using Microsoft.EntityFrameworkCore;
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
}
