using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.EMailTemplate.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.EMailTemplate.Queries.Handlers;

public class GetEmailTemplatesQueryHandler : IRequestHandler<GetEmailTemplatesQuery, List<EmailTemplateDto>>
{
    private readonly IEmailTemplateRepository _repository;

    public GetEmailTemplatesQueryHandler(IEmailTemplateRepository repository)
    {
        _repository = repository;
    }


    public async Task<List<EmailTemplateDto>> Handle(GetEmailTemplatesQuery request, CancellationToken cancellationToken)
    {
        var templates = request.CategoryId.HasValue
                         ? await _repository.GetByCategoryIdAsync(request.CategoryId.Value)
                         : await _repository.GetAllAsync();

        return templates.Select(x => new EmailTemplateDto
        {
            Id = x.Id,
            CategoryId = x.CategoryId,
            CategoryName = x.Category.Name,
            Title = x.Title,
            Body = x.Body,
            Description = x.Description,
            CreatedAt = x.CreatedAt
        }).ToList();
    }

}
