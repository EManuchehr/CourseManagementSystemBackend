using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Services
{
    public class CourseService : IBaseService<Course>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<Course> CreateAsync(Course course, CancellationToken token = default)
        {
            return await _courseRepository.CreateAsync(course, token);
        }

        public async Task<bool> DeleteAsync(Course course, CancellationToken token = default)
        {
            return await _courseRepository.DeleteAsync(course, token);
        }

        public async Task<IEnumerable<Course>> GetAllAsync(CancellationToken token = default)
        {
            return await _courseRepository.GetAllAsync(token);
        }

        public async Task<Course> GetAsync(int id, CancellationToken token = default)
        {
            return await _courseRepository.GetAsync(id, token);
        }

        public async Task<bool> UpdateAsync(Course course, CancellationToken token = default)
        {
            var existingCourse = await GetAsync(course.Id);

            if (existingCourse is null)
            {
                return false;
            }

            existingCourse.Name = course.Name;
            existingCourse.Description = course.Description;
            existingCourse.Teacher = course.Teacher;
            existingCourse.Students = course.Students; // Assuming Students is a collection
            existingCourse.Schedule = course.Schedule;
            existingCourse.StudyMaterials = course.StudyMaterials; // Assuming StudyMaterials is a collection

            return await _courseRepository.UpdateAsync(existingCourse, token);
        }

        // Additional methods specific to CourseService can be implemented here

        public async Task<bool> AddStudentToCourseAsync(int courseId, int studentId, CancellationToken token = default)
        {
            var course = await GetAsync(courseId, token);
            if (course == null)
            {
                return false;
            }

            // Implement logic to add student to course.Students collection
            // This might involve retrieving student data from another repository

            return await UpdateAsync(course, token);
        }

    }
}
