using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Persistence.Configurations;

public class BrandEntityConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {

        //Seed Data
        builder.HasData(new List<Brand>()
        {
            new(){ Id=1, Name="BMW" },
            new(){ Id=2, Name="Audi" },
        });
    }
}
