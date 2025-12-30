using CatApi.Application.Interfaces;
using CatApi.Domain.Entities;

namespace CatApi.Application.Services;

public class ImageService : IImageService
{
    private readonly ICatApiClient _client;

    public ImageService(ICatApiClient client)
    {
        _client = client;
    }

    public Task<IEnumerable<CatImage>> GetImagesByBreedIdAsync(string breedId)
        => _client.GetImagesByBreedIdAsync(breedId);
}
