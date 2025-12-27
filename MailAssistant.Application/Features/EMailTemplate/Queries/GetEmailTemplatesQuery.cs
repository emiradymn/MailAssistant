using MailAssistant.Application.Features.EMailTemplate.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.EMailTemplate.Queries;

public record GetEmailTemplatesQuery(Guid? CategoryId)
    : IRequest<List<EmailTemplateDto>>;
// Record kullanıyoruz çünkü Query nesneleri immutable, sadece veri taşıyan
// request modelleridir ve value-based equality CQRS için daha uygundur.
//Oluşturulduktan sonra değiştirilemeyen nesne (immutable)