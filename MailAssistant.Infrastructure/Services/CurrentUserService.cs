using System.Security.Claims;
using MailAssistant.Application.Common.Interfaces.Services;
using Microsoft.AspNetCore.Http;

namespace MailAssistant.Infrastructure.Services;

public class CurrentUserService : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid UserId =>
        Guid.Parse(
            _httpContextAccessor.HttpContext!
                .User.FindFirstValue(ClaimTypes.NameIdentifier)!);

}
