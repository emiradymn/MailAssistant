using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Common.Interfaces.Repositories;

public interface IUserRepository
{
    Task<AppUser?> GetUserProfileAsync(Guid userId);
}
