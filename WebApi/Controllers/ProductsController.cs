using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ISearchService searchService;

    public ProductsController(ISearchService searchService)
    {
        this.searchService = searchService;
    }

    [HttpGet]
    public async Task<ActionResult<ProductSearchDto>> SearchByName(string name)
    {
        var result = await searchService.GetByNameAsync(name);
        return Ok(result);
    }
}
