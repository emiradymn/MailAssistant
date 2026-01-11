namespace MailAssistant.Application.Common.Interfaces.Services;

public interface ICurrentUserService
{
    Guid UserId { get; }
}
