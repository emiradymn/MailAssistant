using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.SendMailForm.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.SendMailForm.Queries.Handlers;

public class GetEmailTemplateByIdQueryHandler : IRequestHandler<GetEmailTemplateByIdQuery, EmailTemplateDetailDto>
{
    private readonly ISendMailFormRepository _repository;

    public GetEmailTemplateByIdQueryHandler(ISendMailFormRepository repository)
    {
        _repository = repository;
    }


    public async Task<EmailTemplateDetailDto> Handle(GetEmailTemplateByIdQuery request, CancellationToken cancellationToken)
    {
        var template = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (template is null)
            throw new Exception("Email Template bulunamadı");

        return new EmailTemplateDetailDto
        {
            Id = template.Id,
            CategoryId = template.CategoryId,
            Title = template.Title,
            Body = template.Body,
            Description = template.Description
        };
    }

}
