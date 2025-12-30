using CatApi.Application.Interfaces;
using CatApi.Domain.Entities;

namespace CatApi.Application.Services;

public class CatService : ICatService
{
    private readonly ICatApiClient _client;

    public CatService(ICatApiClient client)
    {
        _client = client;
    }

    public Task<IEnumerable<Breed>> GetBreedsAsync()
        => _client.GetBreedsAsync();

    public Task<Breed?> GetBreedByIdAsync(string breedId)
        => _client.GetBreedByIdAsync(breedId);

    public Task<IEnumerable<Breed>> SearchBreedsAsync(string query)
        => _client.SearchBreedsAsync(query);
}
