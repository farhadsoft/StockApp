using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ISearchService searchService;
    private readonly IUploadService uploadService;

    public ProductsController(ISearchService searchService, IUploadService uploadService)
    {
        this.searchService = searchService;
        this.uploadService = uploadService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductNameDto>>> GetProductsName()
    {
        var result = await searchService.GetAllNames();
        return Ok(result);
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<ProductSearchDto>> SearchByName(string name)
    {
        var result = await searchService.GetByNameAsync(name);
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult> Update(IEnumerable<ProductAddDto> products)
    {
        await uploadService.AddAsync(products);
        return Ok();
    }
}
