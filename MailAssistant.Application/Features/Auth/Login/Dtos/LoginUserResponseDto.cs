namespace MailAssistant.Application.Features.Auth.Login.Dtos;

public class LoginUserResponseDto
{
    public bool Success { get; set; }
    public string Token { get; set; }
    public Guid? UserId { get; set; }
    public string Message { get; set; }
    public List<string> Errors { get; set; } = new();
}
