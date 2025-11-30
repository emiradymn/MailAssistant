namespace MailAssistant.Domain.Entities;

public class TemplateParameter
{
    public Guid Id { get; set; }

    public Guid TemplateId { get; set; }
    public EmailTemplate Template { get; set; } = null!;

    public string Key { get; set; } = null!;
    public string Label { get; set; } = null!;
    public string InputType { get; set; } = "text";
}

