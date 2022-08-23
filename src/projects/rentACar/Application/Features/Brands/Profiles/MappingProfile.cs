using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.Dtos;
using AutoMapper;
using Domain.Entities;
namespace Application.Features.Brands.Profiles;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Brand, CreatedBrandDto>();
        CreateMap<CreateBrandCommand, Brand>();
    }
}
