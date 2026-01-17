using AutoMapper.Configuration.Conventions;
using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Application.Common.Interfaces.Services;
using MailAssistant.Domain.Entities;
using MediatR;

namespace MailAssistant.Application.Features.SendMail.Commands.Handlers;

public class SendMailCommandHandler : IRequestHandler<SendMailCommand, Guid>
{

    private readonly IEmailSender _emailSender;
    private readonly IEmailTemplateRepository _templateRepository;
    private readonly ISentEmailRepository _sentEmailRepository;
    private readonly ICurrentUserService _currentUserService;

    public SendMailCommandHandler(IEmailSender emailSender, IEmailTemplateRepository templateRepository, ISentEmailRepository sentEmailRepository, ICurrentUserService currentUserService)
    {
        _emailSender = emailSender;
        _templateRepository = templateRepository;
        _sentEmailRepository = sentEmailRepository;
        _currentUserService = currentUserService;

    }

    public async Task<Guid> Handle(SendMailCommand request, CancellationToken cancellationToken)
    {
        var template = await _templateRepository.GetByIdAsync(request.TemplateId);

        if (template is null)
            throw new Exception("Mail Şablonu bulunamadı");

        var body = ReplaceParams(template.Body, request.Params);

        if (!string.IsNullOrWhiteSpace(request.Signature))
        {
            body = body.Replace("{{Signature}}", request.Signature);
        }

        var sentEmail = new SentEmail
        {
            Id = Guid.NewGuid(),
            UserId = _currentUserService.UserId,
            TemplateId = template.Id,
            FromEmail = request.From,
            ToEmail = request.To,
            Subject = request.Subject,
            Body = body,
            Signature = request.Signature,
            PdfPath = request.FileName
        };

        await _sentEmailRepository.AddAsync(sentEmail);
        await _sentEmailRepository.SaveChangesAsync();

        await _emailSender.SendAsync(
             request.From,
            request.To,
            request.Subject,
            body,
            request.FileContent,
            request.FileName,
            request.ContentType
        );
        return sentEmail.Id
;
    }

    private static string ReplaceParams(string body, Dictionary<string, string> parameters)
    {
        foreach (var item in parameters)
            body = body.Replace($"{{{{{item.Key}}}}}", item.Value);

        return body;
    }

}
