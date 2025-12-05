using System.Reflection.Metadata;
using MailAssistant.Application.Interfaces.Services;
using MailAssistant.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MailAssistant.Infrastructure.Services;

public class IdentityService : IUserService
{
    private readonly UserManager<AppUser> _userManager;

    public IdentityService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<(bool Succeded, string Message)> RegisterAsync(AppUser user, string password)
    {
        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            var error = string.Join(" |", result.Errors.Select(x => x.Description));
            return (false, error);
        }

        return (true, "Kullanıcı başarıyla oluşturuldu");
    }

}
