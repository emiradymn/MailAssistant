using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string? FullName { get; set; }
    public string? Address { get; set; }
    public string? CurrentPosition { get; set; }
    public string? DefaultSignature { get; set; }

    public ICollection<SentEmail> SentEmails { get; set; } = new List<SentEmail>();
    public ICollection<UserDocument> Documents { get; set; } = new List<UserDocument>();
}


