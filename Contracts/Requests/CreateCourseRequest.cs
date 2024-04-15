namespace Contracts.Requests;

public class CreateCourseRequest
{
    public required string Title { get; init; }
    public Guid InstructorId { get; init; }
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public required string Description { get; init; }
}