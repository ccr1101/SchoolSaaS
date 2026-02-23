using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSaaS.Application.DTOs;

namespace SchoolSaaS.Application.Interfaces;

public interface IAuthService
{
    Task<string> RegistersSchoolAsync(RegisterSchoolRequest request);
    Task<string> LoginAsync(LoginRequest request);
}
