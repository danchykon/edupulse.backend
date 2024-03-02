using EduPulse.Domain.Enums;

namespace EduPulse.Application.Dtos;

public record UserDto
{
    public required Guid Id { get; init; }
    public required string PhoneNumber { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required int Age { get; set; }
    public required UserRole Role { get; set; }
    public DateTimeOffset CreatedAt { get; init; }
}