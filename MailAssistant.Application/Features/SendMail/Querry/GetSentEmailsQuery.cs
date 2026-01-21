using MailAssistant.Application.Features.SendMail.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.SendMail.Querry;

public class GetSentEmailsQuery : IRequest<List<SentEmailListDto>>
{
    public Guid UserId { get; }
    public string? Search { get; }

    public GetSentEmailsQuery(Guid userId, string? search)
    {
        UserId = userId;
        Search = search;
    }
}
