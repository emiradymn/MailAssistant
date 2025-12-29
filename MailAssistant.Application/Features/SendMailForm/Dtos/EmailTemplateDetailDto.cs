namespace MailAssistant.Application.Features.SendMailForm.Dtos;

public class EmailTemplateDetailDto
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }

    public string Title { get; set; } = null!;
    public string Body { get; set; } = null!;

    public string? Description { get; set; }


}
