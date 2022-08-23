using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
namespace Application.Features.Brands.Rules;

public class BrandBusinessRules
{
    private readonly IBrandRepository _brandRepository;

    public BrandBusinessRules(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
    {
        bool brandExists = await _brandRepository.AnyAsync(b => b.Name == name);

        if (brandExists) throw new BusinessException("Brand name exists.");
    }
}
