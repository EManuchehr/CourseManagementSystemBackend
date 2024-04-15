using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class TaskAssignmentService : IBaseService<TaskAssignment>
    {
        private readonly IBaseRepository<TaskAssignment> _taskAssignmentRepository;

        public TaskAssignmentService(IBaseRepository<TaskAssignment> taskAssignmentRepository)
        {
            _taskAssignmentRepository = taskAssignmentRepository;
        }

        public async Task<TaskAssignment> CreateAsync(TaskAssignment assignment, CancellationToken token = default)
        {
            return await _taskAssignmentRepository.CreateAsync(assignment, token);
        }

        public async Task<bool> DeleteAsync(TaskAssignment assignment, CancellationToken token = default)
        {
            return await _taskAssignmentRepository.DeleteAsync(assignment, token);
        }

        public async Task<IEnumerable<TaskAssignment>> GetAllAsync(CancellationToken token = default)
        {
            return await _taskAssignmentRepository.GetAllAsync(token);
        }

        public async Task<TaskAssignment> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _taskAssignmentRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(TaskAssignment assignment, CancellationToken token = default)
        {
            var existingAssignment = await GetAsync(assignment.Id);

            if (existingAssignment is null)
            {
                return false;
            }

            existingAssignment.Title = assignment.Title;
            existingAssignment.Description = assignment.Description;
            existingAssignment.Due_date = assignment.Due_date;

            return await _taskAssignmentRepository.UpdateAsync(existingAssignment, token);
        }
    }
}