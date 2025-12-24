using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Persistence.Repositories;

public class EmailTemplateCategoryRepository : IEmailTemplateCategoryRepository
{
    private readonly AppDbContext _context;

    public EmailTemplateCategoryRepository(AppDbContext context)
    {
        _context = context;
    }


    public async Task<List<EmailTemplateCategory>> GetAllAsync()
    {
        return await _context.EmailTemplateCategories
           .AsNoTracking()
           .ToListAsync();
    }

}
