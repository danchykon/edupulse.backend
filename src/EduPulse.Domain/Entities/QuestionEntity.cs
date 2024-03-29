namespace EduPulse.Domain.Entities;

public class QuestionEntity
{
    public required Guid Id { get; init; }
    public required Guid TestId { get; set; }
    public required string Title { get; set; }
    public required int Points { get; set; }
    public List<AnswerEntity> Answers { get; set; } = new();
    public Guid CorrectAnswerId { get; set; }
}