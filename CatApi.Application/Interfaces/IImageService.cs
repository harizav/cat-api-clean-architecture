using CatApi.Domain.Entities;

namespace CatApi.Application.Interfaces;

public interface IImageService
{
    Task<IEnumerable<CatImage>> GetImagesByBreedIdAsync(string breedId);
}
