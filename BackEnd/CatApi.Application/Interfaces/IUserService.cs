using CatApi.Domain.Entities;

namespace CatApi.Application.Interfaces;

public interface IUserService
{
    Task<User?> LoginAsync(string username, string password);
    Task<User> RegisterAsync(User user);
}
