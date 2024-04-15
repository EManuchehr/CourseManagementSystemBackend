namespace Domain.Entities;

public class Course : BaseEntity
{
    public required string Title { get; set; }
    public Guid InstructorId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public required string Description { get; set; }

    public Instructor Instructor { get; set; }
    public virtual ICollection<Material> Materials { get; set; }
    public virtual ICollection<Assignment> Assignments { get; set; }
    public virtual ICollection<Submission> Submissions { get; set; }
    public virtual ICollection<Enrollment> Enrollments { get; set; }
    public virtual ICollection<Student> Students { get; set; }
}