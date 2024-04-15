using Domain.Entities;

namespace Contracts.Responses;

public class GetCourseResponse
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public Guid InstructorId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public required string Description { get; set; }

    public required GetCourseResponseInstructor Instructor { get; set; }
}

public class GetCourseResponseInstructor
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
    public required string Description { get; set; }
}