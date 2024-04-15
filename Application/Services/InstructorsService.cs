using System;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class InstructorsService : IBaseService<Instructors>
    {
        private readonly IBaseRepository<Instructors> _InstructorsRepository;

        public InstructorsService(IBaseRepository<Instructors> InstructorsRepository)
        {
            _InstructorsRepository = InstructorsRepository;
        }

        public async Task<Instructors> CreateAsync(Instructors Instructors, CancellationToken token = default)
        {
            return await _InstructorsRepository.CreateAsync(Instructors, token);
        }

        public async Task<bool> DeleteAsync(Instructors Instructors, CancellationToken token = default)
        {
            return await _InstructorsRepository.DeleteAsync(Instructors, token);
        }

        public async Task<IEnumerable<Instructors>> GetAllAsync(CancellationToken token = default)
        {
            return await _InstructorsRepository.GetAllAsync(token);
        }

        public async Task<Instructors> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _InstructorsRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Instructors Instructors, CancellationToken token = default)
        {
            var existingInstructors = await GetAsync(Instructors.Id);

            if (existingInstructors is null)
            {
                return false;
            }

            existingInstructors.first_name = Instructors.first_name;
            existingInstructors.last_name = Instructors.last_name;
            existingInstructors.email = Instructors.email;


            return await _InstructorsRepository.UpdateAsync(existingInstructors, token);
        }
    }
}
