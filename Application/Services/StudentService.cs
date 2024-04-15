using System;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services

public class StudentService : IBaseService<Student>
{
    private readonly IBaseRepository<Student> _studentRepository;

    public StudentService(IBaseRepository<Student> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task<Student> CreateAsync(Student student, CancellationToken token = default)
    {
        return await _studentRepository.CreateAsync(student, token);
    }

    public async Task<bool> DeleteAsync(Student student, CancellationToken token = default)
    {
        return await _studentRepository.DeleteAsync(student, token);
    }

    public async Task<IEnumerable<Student>> GetAllAsync(CancellationToken token = default)
    {
        return await _studentRepository.GetAllAsync(token);
    }

    public async Task<Student> GetAsync(Guid id, CancellationToken token = default)
    {
        return await _studentRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Student student, CancellationToken token = default)
    {
        var existingStudent = await GetAsync(student.Id);

        if (existingStudent is null)
        {
            return false;
        }


        existingStudent.First_name = student.First_name;
        existingStudent.Last_name = student.Last_name;
        existingStudent.Email = student.Email;


        return await _studentRepository.UpdateAsync(existingStudent, token);
    }
}
}