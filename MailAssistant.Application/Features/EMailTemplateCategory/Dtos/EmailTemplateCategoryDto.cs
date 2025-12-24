namespace MailAssistant.Application.Features.EMailTemplateCategory.Dtos;

public class EmailTemplateCategoryDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}
