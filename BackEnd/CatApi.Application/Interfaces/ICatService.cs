using CatApi.Domain.Entities;

namespace CatApi.Application.Interfaces;

public interface ICatService
{
    Task<IEnumerable<Breed>> GetBreedsAsync();
    Task<Breed?> GetBreedByIdAsync(string breedId);
    Task<IEnumerable<Breed>> SearchBreedsAsync(string query);
}
