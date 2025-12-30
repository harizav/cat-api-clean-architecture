using CatApi.Domain.Entities;

namespace CatApi.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetByUsernameAsync(string username);
    Task CreateAsync(User user);
}
