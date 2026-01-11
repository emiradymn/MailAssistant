using MediatR;

namespace MailAssistant.Application.Features.SendMail.Commands;

public class SendMailCommand : IRequest<Guid>
{
    public Guid TemplateId { get; set; }

    public string From { get; set; } = null!;
    public string To { get; set; } = null!;
    public string Subject { get; set; } = null!;

    public Dictionary<string, string> Params { get; set; } = new();

    public byte[]? FileContent { get; set; }
    public string? FileName { get; set; }
    public string? ContentType { get; set; }
}
