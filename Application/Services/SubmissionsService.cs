using System;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services

public class SubmissionsService : IBaseService<Submissions>
{
    private readonly IBaseRepository<Submissions> _SubmissionsRepository;

    public SubmissionsService(IBaseRepository<Submissions> SubmissionsRepository)
    {
        _SubmissionsRepository = SubmissionsRepository;
    }

    public async Task<Submissions> CreateAsync(Submissions Submissions, CancellationToken token = default)
    {
        return await _SubmissionsRepository.CreateAsync(Submissions, token);
    }

    public async Task<bool> DeleteAsync(Submissions Submissions, CancellationToken token = default)
    {
        return await _SubmissionsRepository.DeleteAsync(Submissions, token);
    }

    public async Task<IEnumerable<Submissions>> GetAllAsync(CancellationToken token = default)
    {
        return await _SubmissionsRepository.GetAllAsync(token);
    }

    public async Task<Submissions> GetAsync(Guid id, CancellationToken token = default)
    {
        return await _SubmissionsRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Submissions Submissions, CancellationToken token = default)
    {
        var existingSubmissions = await GetAsync(Submissions.Id);

        if (existingSubmissions is null)
        {
            return false;
        }

        existingSubmissions.submission_date = Submissions.submission_date;
        existingSubmissions.grade = Submissions.grade;



        return await _SubmissionsRepository.UpdateAsync(existingSubmissions, token);
    }
}
}