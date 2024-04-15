namespace Domain.Entities;

public class Material : BaseEntity
{
    public required string Title { get; set; }
    public Guid CourseId { get; set; }
    public required string Description { get; set; }
    public required string Url { get; set; }

    public Course Course { get; set; }
}