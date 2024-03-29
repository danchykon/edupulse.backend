namespace EduPulse.Application.Dtos;

public record TeacherDto
{
    public required Guid Id { get; init; }
    public required string FullName { get; init; }
    public required string Email { get; init; }
    public SubjectDto[] Subjects { get; init; } = Array.Empty<SubjectDto>();
    public DateTimeOffset CreatedAt { get; init; }
}