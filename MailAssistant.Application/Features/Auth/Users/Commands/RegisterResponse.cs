namespace MailAssistant.Application.Features.Users.Commands;

public class RegisterResponse
{
    public bool Succeeded { get; set; }
    public string Message { get; set; } = "";
}
