namespace MailAssistant.Application.Features.Auth.Login.Dtos;

public class LoginUserRequestDto
{
    public string UserNameOrEmail { get; set; } = null!;
    public string Password { get; set; } = null!;
}
