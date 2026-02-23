using SchoolSaaS.Application.DTOs;
using SchoolSaaS.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSaaS.Application.Services;

public class AuthService: IAuthService
{
    private readonly AppDbContext _context;

    public AuthService()
    {

    }
    Task<string> RegistersSchoolAsync(RegisterSchoolRequest request);
    Task<string> LoginAsync(LoginRequest request);
}
