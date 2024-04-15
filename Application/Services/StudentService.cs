using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class StudentService(IBaseRepository<Student> studentRepository) : IBaseService<Student>
{
    public async Task<Student> CreateAsync(Student student, CancellationToken token = default)
    {
        return await studentRepository.CreateAsync(student, token);
    }

    public async Task<bool> DeleteAsync(Student submission, CancellationToken token = default)
    {
        return await studentRepository.DeleteAsync(submission, token);
    }

    public async Task<IEnumerable<Student>> GetAllAsync(CancellationToken token = default)
    {
        return await studentRepository.GetAllAsync(token);
    }

    public async Task<Student> GetAsync(Guid id, CancellationToken token = default)
    {
        return await studentRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Student student, CancellationToken token = default)
    {
        return await studentRepository.UpdateAsync(student, token);
    }
}