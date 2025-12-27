using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Common.Interfaces.Repositories;

public interface IEmailTemplateRepository
{
    Task<List<EmailTemplate>> GetAllAsync();
    Task<List<EmailTemplate>> GetByCategoryIdAsync(Guid categoryId);
    Task<EmailTemplate?> GetByIdAsync(Guid id);
}
