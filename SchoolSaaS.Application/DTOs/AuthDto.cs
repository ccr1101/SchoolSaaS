using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSaaS.Application.DTOs;

public record RegisterSchoolRequest(
    string SchoolName,
    string Address,
    string Phone,
    string Email,
    string Password
);

public record LoginRequest(
    string Email,
    string Password
);
