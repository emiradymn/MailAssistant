using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Common.Interfaces.Repositories;

public interface IEmailTemplateCategoryRepository
{
    Task<List<EmailTemplateCategory>> GetAllAsync();
}
