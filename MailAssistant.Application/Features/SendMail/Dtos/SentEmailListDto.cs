namespace MailAssistant.Application.Features.SendMail.Dtos;

public class SentEmailListDto
{
    public Guid Id { get; set; }
    public string ToEmail { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string BodyPreview { get; set; } = null!;
    public DateTime SentAt { get; set; }
}
