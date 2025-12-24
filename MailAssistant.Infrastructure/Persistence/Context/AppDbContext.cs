using MailAssistant.Domain.Entities;
using MailAssistant.Infrastructure.Seeds;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Persistence.Context;

public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<EmailTemplateCategory> EmailTemplateCategories { get; set; }
    public DbSet<EmailTemplate> EmailTemplates { get; set; }
    public DbSet<TemplateParameter> TemplateParameters { get; set; }
    public DbSet<SentEmail> SentEmails { get; set; }
    public DbSet<UserDocument> UserDocuments { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        EmailTemplateCategorySeed.Seed(builder);
        EmailTemplateSeed.Seed(builder);

        // EmailTemplateCategory → Templates (1 - n)
        builder.Entity<EmailTemplateCategory>()
            .HasMany(c => c.Templates)
            .WithOne(t => t.Category)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.Cascade);

        // EmailTemplate → Parameters (1 - n)
        builder.Entity<EmailTemplate>()
            .HasMany(t => t.Parameters)
            .WithOne(p => p.Template)
            .HasForeignKey(p => p.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);

        // EmailTemplate → SentEmails (1 - n)
        builder.Entity<EmailTemplate>()
            .HasMany(t => t.SentEmails)
            .WithOne(s => s.Template)
            .HasForeignKey(s => s.TemplateId);

        // AppUser → SentEmails (1 - n)
        builder.Entity<AppUser>()
            .HasMany(u => u.SentEmails)
            .WithOne(s => s.User)
            .HasForeignKey(s => s.UserId);

        // AppUser → UserDocuments (1 - n)
        builder.Entity<AppUser>()
            .HasMany(u => u.Documents)
            .WithOne(d => d.User)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // Default değerler
        builder.Entity<EmailTemplate>()
            .Property(t => t.CreatedAt)
            .HasDefaultValueSql("NOW()");

        builder.Entity<SentEmail>()
            .Property(t => t.SentAt)
            .HasDefaultValueSql("NOW()");

        builder.Entity<UserDocument>()
            .Property(d => d.UploadedAt)
            .HasDefaultValueSql("NOW()");
    }
}
