using Application.Services.Repositories;
using Core.Persistemce.Repositories;
using Domain.Entities;
using Persistence.Contexts;
namespace Persistence.Repositories;

public class BrandRepository : BaseRepository<ApplicationDbContext, Brand>, IBrandRepository
{
    public BrandRepository(ApplicationDbContext context) : base(context) { }
}
