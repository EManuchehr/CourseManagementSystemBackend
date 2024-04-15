namespace Domain.Entities;

public class Enrollment : BaseEntity
{
    public Guid StudentId { get; set; }
    public Guid CourseId { get; set; }
    public DateTime EnrollmentDate { get; } = DateTime.Now;
    public bool IsActive { get; set; }
    public bool IsCompleted { get; set; }
    public int Grade { get; set; }

    public Student Student { get; set; }
    public Course Course { get; set; }
}