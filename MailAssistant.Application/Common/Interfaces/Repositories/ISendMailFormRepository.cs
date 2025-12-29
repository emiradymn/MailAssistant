using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Common.Interfaces.Repositories;

public interface ISendMailFormRepository
{
    Task<EmailTemplate?> GetByIdAsync(
       Guid id,
       CancellationToken cancellationToken);
}
