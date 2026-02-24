using SchoolSaaS.Application.DTOs;
using SchoolSaaS.Application.Interfaces;
using SchoolSaaS.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSaaS.Application.Services;

public class AuthService: IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly ISchoolRepository _schoolRepository;
    private readonly IJwtService _jwtService;

    public AuthService(IUserRepository userRepository, ISchoolRepository schoolRepository, IJwtService jwtService)
    {
        _userRepository = userRepository;
        _schoolRepository = schoolRepository;
        _jwtService = jwtService;
    }

    public async Task<string> RegistersSchoolAsync(RegisterSchoolRequest request)
    {
        // Check if school name already exists
        var name = _schoolRepository.GetByNameAsync(request.SchoolName);
        if(name != null)
            return
    }
    Task<string> LoginAsync(LoginRequest request);
}
