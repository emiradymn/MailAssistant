using MailAssistant.Application.Common.Interfaces.Repositories;
using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Persistence.Repositories;

public class SendMailFormRepository : ISendMailFormRepository
{
    private readonly AppDbContext _context;

    public SendMailFormRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<EmailTemplate?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _context.EmailTemplates
                             .AsNoTracking()
                             .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

}
