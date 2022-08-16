using Core.Persistemce.Repositories;
using Domain.Entities;
namespace Application.Services.Repositories;

public interface IBrandRepository : IAsyncRepository<Brand>
{
}
