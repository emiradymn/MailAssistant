using MailAssistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MailAssistant.Infrastructure.Seeds;

public static class EmailTemplateSeed
{
    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<EmailTemplate>().HasData(

           new EmailTemplate
           {
               Id = Guid.NewGuid(),
               CategoryId = EmailTemplateCategorySeed.HrCareerId,
               Title = "İş Başvurusu - {{PositionName}}",
               Body = @"Merhaba {{RecipientName}},

{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.
Ekte özgeçmişimi bilgilerinize sunuyorum.

Uygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.

Saygılarımla,
{{SenderName}}",
               CreatedAt = DateTime.UtcNow
           }, new EmailTemplate
           {
               Id = Guid.NewGuid(),
               CategoryId = EmailTemplateCategorySeed.HrCareerId,
               Title = "Staj Başvurusu – {{DepartmentName}}",
               Body =
@"Merhaba {{RecipientName}},

{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.
Staj kapsamında şirketinizde görev almak istiyorum.

Değerlendirmenizi rica ederim.

Saygılarımla,
{{SenderName}}",
               CreatedAt = DateTime.UtcNow
           },

        // ================= Meeting =================

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.MeetingId,
            Title = "Toplantı Talebi – {{MeetingSubject}}",
            Body =
@"Merhaba {{RecipientName}},

{{MeetingSubject}} hakkında görüşmek üzere
{{ProposedDate}} tarihinde toplantı talep ediyorum.

Uygunluğunuzu rica ederim.

İyi çalışmalar,
{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.MeetingId,
            Title = "Toplantı Erteleme Bilgilendirmesi",
            Body =
@"Merhaba {{RecipientName}},

{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.
Yeni tarih ayrıca paylaşılacaktır.

Bilginize sunarım.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        // ================= Technical & Operation =================

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.TechnicalOperationId,
            Title = "Teknik Destek Talebi – {{SystemName}}",
            Body =
@"Merhaba {{SupportTeamName}},

{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:

{{IssueDescription}}

Destek rica ederim.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.TechnicalOperationId,
            Title = "Erişim Yetkisi Talebi – {{SystemName}}",
            Body =
@"Merhaba {{RecipientName}},

{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.

Gereğini rica ederim.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        // ================= Partnership =================

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.PartnershipId,
            Title = "İş Birliği Teklifi",
            Body =
@"Merhaba {{RecipientName}},

Karşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.

Uygunluğunuz halinde detayları görüşmek isteriz.

Saygılarımızla,
{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.PartnershipId,
            Title = "Teklif Talebi – {{ServiceName}}",
            Body =
@"Merhaba {{RecipientName}},

{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren
teklifinizi tarafımıza iletmenizi rica ederiz.

İyi çalışmalar,
{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        // ================= Communication =================

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.CommunicationId,
            Title = "Görev Ataması – {{TaskTitle}}",
            Body =
@"Merhaba {{RecipientName}},

{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.
Son teslim tarihi: {{DueDate}}

Bilginize sunarım.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.CommunicationId,
            Title = "Durum Güncellemesi – {{ProjectName}}",
            Body =
@"Merhaba {{RecipientName}},

{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:

{{StatusSummary}}

Bilginize sunarım.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        // ================= Finance =================

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.FinanceId,
            Title = "Maaş Düzenlenmesi Görüşme Talebi",
            Body =
@"Merhaba {{RecipientName}},

Mevcut sorumluluklarım ve performansım doğrultusunda
maaş düzenlemesi hakkında görüşme talep ediyorum.

Uygun bir zaman belirleyebilirsek memnun olurum.

Saygılarımla,
{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        },

        new EmailTemplate
        {
            Id = Guid.NewGuid(),
            CategoryId = EmailTemplateCategorySeed.FinanceId,
            Title = "Ödeme Talebi – {{InvoiceNumber}}",
            Body =
@"Merhaba {{RecipientName}},

{{InvoiceNumber}} numaralı faturaya ait ödemenin
tarafımıza iletilmesini rica ederiz.

Bilgilerinize sunarız.

{{SenderName}}",
            CreatedAt = DateTime.UtcNow
        }
        );
    }
}
