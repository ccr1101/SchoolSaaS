using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSaaS.Domain.Entities;

public class Student
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public Guid SchoolId { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string GuardianName { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
