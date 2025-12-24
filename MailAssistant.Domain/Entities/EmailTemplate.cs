namespace MailAssistant.Domain.Entities;

public class EmailTemplate
{
    public Guid Id { get; set; }

    public Guid CategoryId { get; set; }
    public Guid? UserId { get; set; }
    public AppUser? User { get; set; }
    public string? Description { get; set; }

    public EmailTemplateCategory Category { get; set; } = null!;

    public string Title { get; set; } = null!;
    public string Body { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public ICollection<TemplateParameter> Parameters { get; set; } = new List<TemplateParameter>();
    public ICollection<SentEmail> SentEmails { get; set; } = new List<SentEmail>();
}

