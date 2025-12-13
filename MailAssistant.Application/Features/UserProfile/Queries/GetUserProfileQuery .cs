using MailAssistant.Application.Features.UserProfile.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.UserProfile.Queries;

public class GetUserProfileQuery : IRequest<ListUserProfileDto>
{
    public Guid UserId { get; set; }

    public GetUserProfileQuery(Guid userId)
    {
        UserId = userId;
    }
}
