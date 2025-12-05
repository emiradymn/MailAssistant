namespace MailAssistant.Application.Features.Users.Dtos;

public class RegisterUserResponseDto
{
    public bool Success { get; set; }
    public Guid UserId { get; set; }
    public string Message { get; set; } = null!;
    public List<string> Errors { get; set; } = new();
}
