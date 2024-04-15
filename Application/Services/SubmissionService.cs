using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services;

public class SubmissionService(IBaseRepository<Submission> submissionRepository) : IBaseService<Submission>
{
    public async Task<Submission> CreateAsync(Submission submission, CancellationToken token = default)
    {
        return await submissionRepository.CreateAsync(submission, token);
    }

    public async Task<bool> DeleteAsync(Submission submission, CancellationToken token = default)
    {
        return await submissionRepository.DeleteAsync(submission, token);
    }

    public async Task<IEnumerable<Submission>> GetAllAsync(CancellationToken token = default)
    {
        return await submissionRepository.GetAllAsync(token);
    }

    public async Task<Submission> GetAsync(Guid id, CancellationToken token = default)
    {
        return await submissionRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Submission submission, CancellationToken token = default)
    {
        return await submissionRepository.UpdateAsync(submission, token);
    }
}