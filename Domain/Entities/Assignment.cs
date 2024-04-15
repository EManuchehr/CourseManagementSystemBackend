namespace Domain.Entities;

public class Assignment : BaseEntity
{
    public required string Title { get; set; }
    public Guid CourseId { get; set; }
    public DateOnly DueDate { get; set; }
    public required string Description { get; set; }

    public Course Course { get; set; }
}