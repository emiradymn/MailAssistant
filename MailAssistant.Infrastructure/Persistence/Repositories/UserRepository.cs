using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Persistence.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<AppUser?> GetUserProfileAsync(Guid userId)
    {
        return await _context.Users
            .FirstOrDefaultAsync(u => u.Id == userId);
    }


}
