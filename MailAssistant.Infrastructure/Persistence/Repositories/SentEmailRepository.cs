using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;

namespace MailAssistant.Infrastructure.Persistence.Repositories;

public class SentEmailRepository : ISentEmailRepository
{
    private readonly AppDbContext _context;

    public SentEmailRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task AddAsync(SentEmail sentEmail)
    {
        await _context.SentEmails.AddAsync(sentEmail);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

}
