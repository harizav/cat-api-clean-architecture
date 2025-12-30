using CatApi.Application.Interfaces;
using CatApi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CatApi.Api.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    // GET /users/login?username=a&password=b
    [HttpGet("login")]
    public async Task<IActionResult> Login(
        [FromQuery] string username,
        [FromQuery] string password)
    {
        var user = await _userService.LoginAsync(username, password);

        if (user is null)
            return Unauthorized();

        return Ok(user);
    }

    // GET /users/register
    [HttpGet("register")]
    public async Task<IActionResult> Register([FromQuery] string username,
                                              [FromQuery] string email,
                                              [FromQuery] string password)
    {
        var user = new User
        {
            Username = username,
            Email = email,
            PasswordHash = password,
            CreatedAt = DateTime.UtcNow
        };

        var created = await _userService.RegisterAsync(user);
        return Ok(created);
    }
}
