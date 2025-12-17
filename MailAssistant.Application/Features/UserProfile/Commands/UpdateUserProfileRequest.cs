namespace MailAssistant.Application.Features.UserProfile.Commands;

public class UpdateUserProfileRequest
{
    public string FullName { get; set; } = null!;
    public string UserName { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string? CurrentPosition { get; set; }
    public string? DefaultSignature { get; set; }
}