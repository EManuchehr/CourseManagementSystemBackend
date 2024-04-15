using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class InstructorService(IBaseRepository<Instructor> instructorRepository) : IBaseService<Instructor>
{
    public async Task<Instructor> CreateAsync(Instructor instructor, CancellationToken token = default)
    {
        return await instructorRepository.CreateAsync(instructor, token);
    }

    public async Task<bool> DeleteAsync(Instructor submission, CancellationToken token = default)
    {
        return await instructorRepository.DeleteAsync(submission, token);
    }

    public async Task<IEnumerable<Instructor>> GetAllAsync(CancellationToken token = default)
    {
        return await instructorRepository.GetAllAsync(token);
    }

    public async Task<Instructor> GetAsync(Guid id, CancellationToken token = default)
    {
        return await instructorRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Instructor instructor, CancellationToken token = default)
    {
        return await instructorRepository.UpdateAsync(instructor, token);
    }
}