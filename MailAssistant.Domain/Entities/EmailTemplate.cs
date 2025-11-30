namespace MailAssistant.Domain.Entities;

public class EmailTemplate
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public EmailTemplateCategory Category { get; set; }

    public string Title { get; set; } = null!;
    public string Body { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<TemplateParameter> Parameters { get; set; }
    public ICollection<SentEmail> SentEmails { get; set; }
}
