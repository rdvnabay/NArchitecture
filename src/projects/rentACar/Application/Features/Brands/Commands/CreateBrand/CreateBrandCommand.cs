using Application.Features.Brands.Dtos;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
namespace Application.Features.Brands.Commands.CreateBrand;

public class CreateBrandCommand : IRequest<CreatedBrandDto>
{
    public string Name { get; set; }
}


public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandDto>
{
    private readonly IBrandRepository _brandRepository;
    private readonly BrandBusinessRules _brandBusinessRules;
    private readonly IMapper _mapper;

    public CreateBrandCommandHandler(IBrandRepository brandRepository, BrandBusinessRules brandBusinessRules, IMapper mapper)
    {
        _brandRepository = brandRepository;
        _brandBusinessRules = brandBusinessRules;
        _mapper = mapper;
    }

    public async Task<CreatedBrandDto> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
    {
        await _brandBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);

        var brand = _mapper.Map<Brand>(request);
        var createdBrand = await _brandRepository.AddAsync(brand);

        return _mapper.Map<CreatedBrandDto>(createdBrand);
    }
}
