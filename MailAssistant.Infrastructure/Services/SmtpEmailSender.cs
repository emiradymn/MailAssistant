using System.Net;
using System.Net.Mail;
using MailAssistant.Application.Common.Interfaces.Services;
using MailAssistant.Infrastructure.Configuration;
using Microsoft.Extensions.Options;

namespace MailAssistant.Infrastructure.Services;

public class SmtpEmailSender : IEmailSender
{
    private readonly SmtpSettings _settings;

    public SmtpEmailSender(IOptions<SmtpSettings> options)
    {
        _settings = options.Value;
    }


    public async Task SendAsync(string from, string to, string subject, string body, byte[]? fileContent = null, string? fileName = null, string? contentType = null)
    {
        var mail = new MailMessage
        {
            From = new MailAddress(from),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };

        mail.To.Add(to);

        if (fileContent != null && fileName != null)
        {
            var stream = new MemoryStream(fileContent);
            var attachment = new Attachment(stream, fileName, contentType);
            mail.Attachments.Add(attachment);
        }

        using var smtp = new SmtpClient(_settings.Host, _settings.Port)
        {
            Credentials = new NetworkCredential(
                _settings.Username,
                _settings.Password),
            EnableSsl = true
        };

        await smtp.SendMailAsync(mail);
    }

}
