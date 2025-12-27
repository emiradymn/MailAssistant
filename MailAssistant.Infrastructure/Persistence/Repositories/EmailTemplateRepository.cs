using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Persistence.Repositories;

public class EmailTemplateRepository : IEmailTemplateRepository
{
    private readonly AppDbContext _context;

    public EmailTemplateRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<EmailTemplate>> GetAllAsync()
    {
        return await _context.EmailTemplates
                             .Include(x => x.Category)
                             .AsNoTracking()
                             .OrderByDescending(x => x.CreatedAt)
                             .ToListAsync();
    }

    public async Task<List<EmailTemplate>> GetByCategoryIdAsync(Guid categoryId)
    {
        return await _context.EmailTemplates
                             .Where(X => X.CategoryId == categoryId)
                             .Include(x => x.Category)
                             .AsNoTracking()
                             .OrderByDescending(x => x.CreatedAt)
                             .ToListAsync();
    }

    public async Task<EmailTemplate?> GetByIdAsync(Guid id)
    {
        return await _context.EmailTemplates
                             .Include(x => x.Parameters)
                             .FirstOrDefaultAsync(x => x.Id == id);
    }

}
