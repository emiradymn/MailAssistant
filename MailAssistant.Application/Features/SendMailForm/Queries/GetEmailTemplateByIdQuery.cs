using MailAssistant.Application.Features.SendMailForm.Dtos;
using MediatR;

namespace MailAssistant.Application.Features.SendMailForm.Queries;

public record GetEmailTemplateByIdQuery(Guid Id)
    : IRequest<EmailTemplateDetailDto>;
