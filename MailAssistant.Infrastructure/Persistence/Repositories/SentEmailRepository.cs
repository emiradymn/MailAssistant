using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

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

    public IQueryable<SentEmail> GetAll()
    {
        return _context.SentEmails.AsNoTracking();
    }


    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

}
