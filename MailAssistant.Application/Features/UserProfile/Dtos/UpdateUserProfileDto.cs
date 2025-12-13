namespace MailAssistant.Application.Features.UserProfile.Dtos;

public class UpdateUserProfileDto
{
    public Guid UserId { get; set; }

    public string FullName { get; set; } = null!;
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? CurrentPosition { get; set; }
    public string? DefaultSignature { get; set; }
}
