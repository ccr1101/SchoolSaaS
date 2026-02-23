using SchoolSaaS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSaaS.Application.Repositories;

public interface ISchoolRepository
{
    Task<School?> GetByIdAsync(Guid id);
    Task<School?> GetByNameAsync(string name);
    Task<IEnumerable<School>> GetAllAsync();
    Task AddAsync(School school);
    Task UpdateAsync(School school);
    Task DeleteAsync(Guid id);
}
