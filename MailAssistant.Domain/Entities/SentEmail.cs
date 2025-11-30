namespace MailAssistant.Domain.Entities;

public class SentEmail
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }
    public AppUser User { get; set; }

    public int TemplateId { get; set; }
    public EmailTemplate Template { get; set; }

    public string Subject { get; set; } = null!;
    public string ToEmail { get; set; } = null!;
    public string Body { get; set; } = null!; // Parametreler doldurulmuş final hali

    public string? PdfPath { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}