namespace MailAssistant.API.Models;

public class SendMailRequest
{
    public Guid TemplateId { get; set; }
    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;

    public Dictionary<string, string> Params { get; set; } = new();
    public IFormFile? File { get; set; }
}
