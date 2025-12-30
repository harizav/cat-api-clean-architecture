using CatApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CatApi.Api.Controllers;

[ApiController]
[Route("imagesbybreedid")]
public class ImagesController : ControllerBase
{
    private readonly IImageService _imageService;

    public ImagesController(IImageService imageService)
    {
        _imageService = imageService;
    }

    // GET /imagesbybreedid?breedId=abc
    [HttpGet]
    public async Task<IActionResult> GetImagesByBreedId([FromQuery] string breedId)
    {
        if (string.IsNullOrWhiteSpace(breedId))
            return BadRequest("breedId is required");

        var images = await _imageService.GetImagesByBreedIdAsync(breedId);
        return Ok(images);
    }
}
