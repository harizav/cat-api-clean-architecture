namespace CatApi.Domain.Entities;

public class CatImage
{
    public string Id { get; set; } = default!;
    public string Url { get; set; } = default!;
    public string BreedId { get; set; } = default!;
}
