using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Persistence.Contexts;

public class ApplicationDbContext:DbContext
{

    //Tables
    public DbSet<Brand> Brands { get; set; }
}
