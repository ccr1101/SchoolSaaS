using Microsoft.EntityFrameworkCore;
using SchoolSaaS.Application.Repositories;
using SchoolSaaS.Domain.Entities;
using SchoolSaaS.Infrastructure.Persistence;

namespace SchoolSaaS.Infrastructure.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Student?> GetByIdAsync(Guid id) =>
        await _context.Students.FindAsync(id);

    public async Task<IEnumerable<Student>> GetBySchoolIdAsync(Guid schoolId) =>
        await _context.Students.Where(s => s.SchoolId == schoolId).ToListAsync();

    public async Task AddAsync(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var students = await _context.Students.FindAsync(id);
        if (students != null)
        {
            _context.Students.Remove(students);
            await _context.SaveChangesAsync();
        }
    }

}                                   
