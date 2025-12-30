using CatApi.Domain.Entities;

namespace CatApi.Application.Interfaces;

public interface ICatApiClient
{
    Task<IEnumerable<Breed>> GetBreedsAsync();
    Task<Breed?> GetBreedByIdAsync(string breedId);
    Task<IEnumerable<Breed>> SearchBreedsAsync(string query);
    Task<IEnumerable<CatImage>> GetImagesByBreedIdAsync(string breedId);
}
