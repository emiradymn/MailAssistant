namespace MailAssistant.Application.Common.Interfaces.Services;

public interface IEmailSender
{
    Task SendAsync(
       string from,
       string to,
       string subject,
       string body,
       byte[]? fileContent = null,
       string? fileName = null,
       string? contentType = null);

}
