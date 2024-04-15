namespace Contracts.Responses;

public class GetCourseResponse
{
    public Guid Id { get; init; }
    public required string Title { get; init; }
    public Guid InstructorId { get; init; }
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public required string Description { get; init; }

    public required GetCourseResponseInstructor Instructor { get; init; }
}

public class GetCourseResponseInstructor
{
    public Guid Id { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required string Email { get; init; }
    public required string PhoneNumber { get; init; }
    public required string Address { get; init; }
    public required string City { get; init; }
    public required string State { get; init; }
    public required string ZipCode { get; init; }
    public required string Country { get; init; }
    public required string Description { get; init; }
}