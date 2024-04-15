namespace Contracts.Requests;

public class CreateCourseRequest
{
    public required string Title { get; set; }
    public Guid InstructorId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public required string Description { get; set; }
}