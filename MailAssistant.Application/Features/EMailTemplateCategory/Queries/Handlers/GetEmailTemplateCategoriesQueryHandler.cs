using System.Data.Common;
using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Features.EMailTemplateCategory.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.EMailTemplateCategory.Queries.Handlers;

public class GetEmailTemplateCategoriesQueryHandler
    : IRequestHandler<GetEmailTemplateCategoriesQuery, List<EmailTemplateCategoryDto>>
{
    private readonly IEmailTemplateCategoryRepository _repository;

    public GetEmailTemplateCategoriesQueryHandler(
        IEmailTemplateCategoryRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<EmailTemplateCategoryDto>> Handle(
        GetEmailTemplateCategoriesQuery request,
        CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();

        return categories.Select(x => new EmailTemplateCategoryDto
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description
        }).ToList();
    }
}