
using MailAssistant.Application.Features.UserProfile.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.UserProfile.Commands;

public class UserProfileUpdateCommand : IRequest<Unit>
{
    public Guid UserId { get; init; }
    public string FullName { get; init; } = null!;
    public string UserName { get; init; } = null!;
    public string? PhoneNumber { get; init; }
    public string? CurrentPosition { get; init; }
    public string? DefaultSignature { get; init; }
}
