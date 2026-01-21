using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.SendMail.Dtos;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Application.Features.SendMail.Querry.Handlers;

public class GetSentEmailsQueryHandler : IRequestHandler<GetSentEmailsQuery, List<SentEmailListDto>>
{

    private readonly ISentEmailRepository _sentEmailRepository;

    public GetSentEmailsQueryHandler(ISentEmailRepository sentEmailRepository)
    {
        _sentEmailRepository = sentEmailRepository;
    }


    public async Task<List<SentEmailListDto>> Handle(GetSentEmailsQuery request, CancellationToken cancellationToken)
    {
        var query = _sentEmailRepository.GetAll()
                                         .Where(x => x.UserId == request.UserId);

        if (!string.IsNullOrWhiteSpace(request.Search))
        {
            query = query.Where(x =>
                    x.ToEmail.Contains(request.Search) || x.Subject.Contains(request.Search));
        }

        return await query
     .OrderByDescending(x => x.SentAt)
     .Select(x => new SentEmailListDto
     {
         Id = x.Id,
         ToEmail = x.ToEmail,
         Subject = x.Subject,
         BodyPreview = x.Body.Length > 80
             ? x.Body.Substring(0, 80) + "..."
             : x.Body,
         SentAt = x.SentAt
     })
     .ToListAsync(cancellationToken);


    }

}
