using Application.Features.Brands.Commands.CreateBrand;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add(CreateBrandCommand brand)
    {
        var result = await Mediator.Send(brand);
        return Created("", result);
    }

}
