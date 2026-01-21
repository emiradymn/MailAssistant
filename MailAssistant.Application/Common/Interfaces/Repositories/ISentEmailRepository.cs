using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Common.Interfaces.Repositories;

public interface ISentEmailRepository
{
    Task AddAsync(SentEmail sentEmail);
    IQueryable<SentEmail> GetAll();
    Task SaveChangesAsync();
}
