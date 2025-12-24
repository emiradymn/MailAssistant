using MailAssistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Seeds;

public static class EmailTemplateCategorySeed
{
    public static readonly Guid HrCareerId =
        Guid.Parse("11111111-1111-1111-1111-111111111111");

    public static readonly Guid MeetingId =
        Guid.Parse("22222222-2222-2222-2222-222222222222");

    public static readonly Guid TechnicalOperationId =
       Guid.Parse("33333333-3333-3333-3333-333333333333");

    public static readonly Guid PartnershipId =
        Guid.Parse("44444444-4444-4444-4444-444444444444");

    public static readonly Guid CommunicationId =
        Guid.Parse("55555555-5555-5555-5555-555555555555");

    public static readonly Guid FinanceId =
        Guid.Parse("66666666-6666-6666-6666-666666666666");


    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmailTemplateCategory>().HasData(
            new EmailTemplateCategory
            {
                Id = HrCareerId,
                Name = "İK & Kariyer",
                Description = "İnsan kaynakları, işe alım ve kariyer süreçleri"
            },
             new EmailTemplateCategory
             {
                 Id = MeetingId,
                 Name = "Toplantı",
                 Description = "Toplantı daveti, hatırlatma ve organizasyon e-postaları"
             },
            new EmailTemplateCategory
            {
                Id = TechnicalOperationId,
                Name = "Teknik Operasyon",
                Description = "Teknik süreçler, bakım ve operasyonel bilgilendirmeler"
            },
            new EmailTemplateCategory
            {
                Id = PartnershipId,
                Name = "İş Birliği",
                Description = "Kurumsal iş birlikleri ve partner iletişimleri"
            },
            new EmailTemplateCategory
            {
                Id = CommunicationId,
                Name = "İletişim",
                Description = "Genel iletişim, duyuru ve bilgilendirme e-postaları"
            },
            new EmailTemplateCategory
            {
                Id = FinanceId,
                Name = "Finans",
                Description = "Faturalama, ödeme ve finansal bilgilendirmeler"
            }
        );
    }
}
