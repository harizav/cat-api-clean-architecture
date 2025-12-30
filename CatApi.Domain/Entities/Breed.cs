namespace CatApi.Domain.Entities;

public class Breed
{
    public string Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Origin { get; set; } = default!;
    public string Temperament { get; set; } = default!;
    public string Description { get; set; } = default!;
}
