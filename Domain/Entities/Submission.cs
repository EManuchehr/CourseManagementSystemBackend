namespace Domain.Entities;

public class Submission : BaseEntity
{
    public Guid AssignmentId { get; set; }
    public Guid StudentId { get; set; }
    public string Url { get; set; }
    public string Grade { get; set; }
    public string Comment { get; set; }

    public Assignment Assignment { get; set; }
    public Student Student { get; set; }
}