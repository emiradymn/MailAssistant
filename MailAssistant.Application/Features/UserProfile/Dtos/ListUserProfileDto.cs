namespace MailAssistant.Application.Features.UserProfile.Dtos;

public class ListUserProfileDto
{
    public Guid UserId { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? CurrentPosition { get; set; }  // entitye ekle
    public string? DefaultSignature { get; set; }
}
