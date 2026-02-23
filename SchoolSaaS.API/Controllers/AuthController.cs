using Microsoft.AspNetCore.Mvc;
using SchoolSaaS.Application.Interfaces;
using SchoolSaaS.Infrastructure.Persistence;

namespace SchoolSaaS.API.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IJwtService _jwtService;

    public AuthController(AppDbContext context, IJwtService jwtService)
    {
        _context = context;
        _jwtService = jwtService;
    }

    [HttpPost("RegisterSchool")]
}
