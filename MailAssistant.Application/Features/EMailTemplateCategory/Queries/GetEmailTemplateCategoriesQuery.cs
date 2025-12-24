using MailAssistant.Application.Features.EMailTemplateCategory.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.EMailTemplateCategory.Queries;

public class GetEmailTemplateCategoriesQuery : IRequest<List<EmailTemplateCategoryDto>>
{

}
