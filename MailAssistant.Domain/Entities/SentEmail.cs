namespace MailAssistant.Domain.Entities;

public class SentEmail
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public AppUser User { get; set; } = null!;

    public Guid TemplateId { get; set; }
    public EmailTemplate Template { get; set; } = null!;

    public string FromEmail { get; set; } = null!;
    public string Subject { get; set; } = null!;
    public string ToEmail { get; set; } = null!;
    public string Body { get; set; } = null!;
    public string? Signature { get; set; }


    public string? PdfPath { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}
