using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class CourseService(IBaseRepository<Course> courseRepository) : IBaseService<Course>
    {
        public async Task<Course> GetAsync(Guid id, CancellationToken token = default)
        {
            return await courseRepository.GetAsync(id, token);
        }

        public async Task<IEnumerable<Course>> GetAllAsync(CancellationToken token = default)
        {
            return await courseRepository.GetAllAsync(token);
        }

        public async Task<Course> CreateAsync(Course instructor, CancellationToken token = default)
        {
            return await courseRepository.CreateAsync(instructor, token);
        }

        public async Task<bool> UpdateAsync(Course entity, CancellationToken token = default)
        {
            return await courseRepository.UpdateAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Course submission, CancellationToken token = default)
        {
            return await courseRepository.DeleteAsync(submission, token);
        }
    }
}