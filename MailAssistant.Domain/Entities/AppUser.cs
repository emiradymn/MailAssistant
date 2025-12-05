using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string? FullName { get; set; }
    public string? DefaultSignature { get; set; }
    public string? Phone { get; set; } // bu kaldırılacak

    public ICollection<SentEmail> SentEmails { get; set; } = new List<SentEmail>();
    public ICollection<UserDocument> Documents { get; set; } = new List<UserDocument>();
    public UserProfile? UserProfile { get; set; }
}

