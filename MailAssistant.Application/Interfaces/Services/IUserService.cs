using System.Reflection.Metadata;
using MailAssistant.Domain.Entities;

namespace MailAssistant.Application.Interfaces.Services;

public interface IUserService
{
    Task<(bool Succeded, string Message)> RegisterAsync(AppUser user, string password);
}
