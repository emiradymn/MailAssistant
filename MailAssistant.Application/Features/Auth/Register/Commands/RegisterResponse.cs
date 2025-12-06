namespace MailAssistant.Application.Features.Register.Commands;

public class RegisterResponse
{
    public bool Succeeded { get; set; }
    public string Message { get; set; } = "";
}
