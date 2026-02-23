using Microsoft.EntityFrameworkCore;
using SchoolSaaS.Application.Repositories;
using SchoolSaaS.Domain.Entities;
using SchoolSaaS.Infrastructure.Persistence;

namespace SchoolSaaS.Infrastructure.Repositories;

public class SchoolRepository : ISchoolRepository
{
    private readonly AppDbContext _context;

    public SchoolRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<School?> GetByIdAsync(Guid id) => 
        await _context.Schools.FindAsync(id);

    public async Task<School?> GetByNameAsync(string name) =>
        await _context.Schools.FirstOrDefaultAsync(s => s.Name == name);

    public async Task<IEnumerable<School>> GetAllAsync() =>
        await _context.Schools.ToListAsync();

    public async Task AddAsync(School school)
    {
        await _context.Schools.AddAsync(school);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(School school)
    {
        _context.Schools.Update(school);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var schools = await _context.Schools.FindAsync(id);
        if (schools != null)
        {
            _context.Schools.Remove(schools);
            await _context.SaveChangesAsync();
        }
    }
}
