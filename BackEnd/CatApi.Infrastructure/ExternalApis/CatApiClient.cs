using System.Net.Http.Json;
using CatApi.Application.Interfaces;
using CatApi.Domain.Entities;

namespace CatApi.Infrastructure.ExternalApis;

public class CatApiClient : ICatApiClient
{
    private readonly HttpClient _httpClient;

    public CatApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Breed>> GetBreedsAsync()
        => await _httpClient.GetFromJsonAsync<IEnumerable<Breed>>("breeds")
           ?? Enumerable.Empty<Breed>();

    public async Task<Breed?> GetBreedByIdAsync(string breedId)
    {
        var breeds = await GetBreedsAsync();
        return breeds.FirstOrDefault(b => b.Id == breedId);
    }

    public async Task<IEnumerable<Breed>> SearchBreedsAsync(string query)
        => await _httpClient.GetFromJsonAsync<IEnumerable<Breed>>($"breeds/search?q={query}")
           ?? Enumerable.Empty<Breed>();

    public async Task<IEnumerable<CatImage>> GetImagesByBreedIdAsync(string breedId)
        => await _httpClient.GetFromJsonAsync<IEnumerable<CatImage>>(
            $"images/search?breed_ids={breedId}&limit=5")
           ?? Enumerable.Empty<CatImage>();
}
