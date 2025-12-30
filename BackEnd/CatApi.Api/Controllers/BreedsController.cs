using CatApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatApi.Api.Controllers;

[ApiController]
[Route("breeds")]
public class BreedsController : ControllerBase
{
    private readonly ICatService _catService;

    public BreedsController(ICatService catService)
    {
        _catService = catService;
    }

    // GET /breeds
    [HttpGet]
    public async Task<IActionResult> GetBreeds()
    {
        var breeds = await _catService.GetBreedsAsync();
        return Ok(breeds);
    }

    // GET /breeds/{breed_id}
    [HttpGet("{breedId}")]
    public async Task<IActionResult> GetBreedById(string breedId)
    {
        var breed = await _catService.GetBreedByIdAsync(breedId);

        if (breed is null)
            return NotFound();

        return Ok(breed);
    }

    // GET /breeds/search?q=abc
    [HttpGet("search")]
    public async Task<IActionResult> SearchBreeds([FromQuery] string q)
    {
        var result = await _catService.SearchBreedsAsync(q);
        return Ok(result);
    }
}
