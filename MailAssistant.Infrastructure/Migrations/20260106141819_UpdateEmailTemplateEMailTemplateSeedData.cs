using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailTemplateEMailTemplateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("21ea9710-7e37-40dd-808d-2947342ef972"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3dcf3280-1a90-4de0-aa18-933fe728e608"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("86efc6c5-d397-4577-8d76-0df2cc12f55b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("9b6adbdd-6a9c-4a07-8c3d-f15953689fa8"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a202d4d7-f2a5-409a-8f68-87dbf63a679a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("b10d2a3c-1551-45ae-966b-8794169bfe10"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c261a781-7274-4a24-8ca9-5408655c00ef"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ce4b77d2-45df-4834-bbb4-68345cdd08c8"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("d345b7fc-b44a-4e39-b453-923afab602e3"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ee9a07ce-6ca1-4649-8f81-7827c2589ee0"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("fce693ce-09d3-4035-b5ec-55eb51e0fe13"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("fd7c210c-0bb6-4ff1-b061-941b1e46e6d9"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CategoryId", "CreatedAt", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("02ae4e56-7f89-4bae-adcf-9b2ed889b2f3"), "Merhaba {{RecipientName}},\n\n{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.\nSon teslim tarihi: {{DueDate}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1724), null, "Görev Ataması", null },
                    { new Guid("059a2bd5-434b-4557-8c69-2f2a3845095a"), "Merhaba {{RecipientName}},\n\n{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:\n\n{{StatusSummary}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1726), null, "Durum Güncellemesi", null },
                    { new Guid("0c849438-6d9b-42a6-af46-0c5bfc93a5b4"), "Merhaba {{RecipientName}},\n\n{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.\nStaj kapsamında şirketinizde görev almak istiyorum.\n\nDeğerlendirmenizi rica ederim.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1655), null, "Staj Başvurusu", null },
                    { new Guid("4463fc99-6998-40da-aee5-1fc941ae38f4"), "Merhaba {{RecipientName}},\n\n{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.\n\nGereğini rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1716), null, "Erişim Yetkisi Talebi", null },
                    { new Guid("554bbd37-01bc-4b97-9ff9-222624e866fe"), "Merhaba {{RecipientName}},\n\n{{InvoiceNumber}} numaralı faturaya ait ödemenin\ntarafımıza iletilmesini rica ederiz.\n\nBilgilerinize sunarız.\n\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1730), null, "Ödeme Talebi", null },
                    { new Guid("62f74ab4-bf66-4d40-adc2-61f8ad7a66a5"), "Merhaba {{RecipientName}},\n\n{{MeetingSubject}} hakkında görüşmek üzere\n{{ProposedDate}} tarihinde toplantı talep ediyorum.\n\nUygunluğunuzu rica ederim.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1657), null, "Toplantı Talebi", null },
                    { new Guid("7594719d-9552-4532-8a27-23c83af0b470"), "Merhaba {{RecipientName}},\n\n{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.\nYeni tarih ayrıca paylaşılacaktır.\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1659), null, "Toplantı Erteleme Bilgilendirmesi", null },
                    { new Guid("93ea04b9-1dff-407d-b21a-05ca062d201c"), "Merhaba {{RecipientName}},\n\n{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren\nteklifinizi tarafımıza iletmenizi rica ederiz.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1720), null, "Teklif Talebi", null },
                    { new Guid("bc87dee3-2169-41b8-94ba-ad43ee304014"), "Merhaba {{SupportTeamName}},\n\n{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:\n\n{{IssueDescription}}\n\nDestek rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1714), null, "Teknik Destek Talebi ", null },
                    { new Guid("c36581cb-19db-48fe-becb-7cac89e001b4"), "Merhaba {{RecipientName}},\n\nKarşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.\n\nUygunluğunuz halinde detayları görüşmek isteriz.\n\nSaygılarımızla,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1718), null, "İş Birliği Teklifi", null },
                    { new Guid("e8c34623-ab86-48f7-827e-3d80f0711d0b"), "Merhaba {{RecipientName}},\n\n{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.\nEkte özgeçmişimi bilgilerinize sunuyorum.\n\nUygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1650), null, "İş Başvurusu", null },
                    { new Guid("f0db027d-a8f3-4d25-a644-0d1f26598c0d"), "Merhaba {{RecipientName}},\n\nMevcut sorumluluklarım ve performansım doğrultusunda\nmaaş düzenlemesi hakkında görüşme talep ediyorum.\n\nUygun bir zaman belirleyebilirsek memnun olurum.\n\nSaygılarımla,\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 6, 14, 18, 18, 714, DateTimeKind.Utc).AddTicks(1728), null, "Maaş Düzenlenmesi Görüşme Talebi", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("02ae4e56-7f89-4bae-adcf-9b2ed889b2f3"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("059a2bd5-434b-4557-8c69-2f2a3845095a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0c849438-6d9b-42a6-af46-0c5bfc93a5b4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("4463fc99-6998-40da-aee5-1fc941ae38f4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("554bbd37-01bc-4b97-9ff9-222624e866fe"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("62f74ab4-bf66-4d40-adc2-61f8ad7a66a5"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("7594719d-9552-4532-8a27-23c83af0b470"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("93ea04b9-1dff-407d-b21a-05ca062d201c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("bc87dee3-2169-41b8-94ba-ad43ee304014"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c36581cb-19db-48fe-becb-7cac89e001b4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("e8c34623-ab86-48f7-827e-3d80f0711d0b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("f0db027d-a8f3-4d25-a644-0d1f26598c0d"));

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CategoryId", "CreatedAt", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("21ea9710-7e37-40dd-808d-2947342ef972"), "Merhaba {{RecipientName}},\n\nKarşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.\n\nUygunluğunuz halinde detayları görüşmek isteriz.\n\nSaygılarımızla,\n{{SenderName}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3261), null, "İş Birliği Teklifi", null },
                    { new Guid("3dcf3280-1a90-4de0-aa18-933fe728e608"), "Merhaba {{RecipientName}},\n\n{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.\nEkte özgeçmişimi bilgilerinize sunuyorum.\n\nUygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.\n\nSaygılarımla,\n{{SenderName}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3247), null, "İş Başvurusu", null },
                    { new Guid("86efc6c5-d397-4577-8d76-0df2cc12f55b"), "Merhaba {{RecipientName}},\n\n{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.\nSon teslim tarihi: {{DueDate}}\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3266), null, "Görev Ataması", null },
                    { new Guid("9b6adbdd-6a9c-4a07-8c3d-f15953689fa8"), "Merhaba {{RecipientName}},\n\n{{InvoiceNumber}} numaralı faturaya ait ödemenin\ntarafımıza iletilmesini rica ederiz.\n\nBilgilerinize sunarız.\n\n{{SenderName}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3306), null, "Ödeme Talebi", null },
                    { new Guid("a202d4d7-f2a5-409a-8f68-87dbf63a679a"), "Merhaba {{SupportTeamName}},\n\n{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:\n\n{{IssueDescription}}\n\nDestek rica ederim.\n\n{{SenderName}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3257), null, "Teknik Destek Talebi ", null },
                    { new Guid("b10d2a3c-1551-45ae-966b-8794169bfe10"), "Merhaba {{RecipientName}},\n\n{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren\nteklifinizi tarafımıza iletmenizi rica ederiz.\n\nİyi çalışmalar,\n{{SenderName}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3262), null, "Teklif Talebi", null },
                    { new Guid("c261a781-7274-4a24-8ca9-5408655c00ef"), "Merhaba {{RecipientName}},\n\n{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.\nStaj kapsamında şirketinizde görev almak istiyorum.\n\nDeğerlendirmenizi rica ederim.\n\nSaygılarımla,\n{{SenderName}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3251), null, "Staj Başvurusu", null },
                    { new Guid("ce4b77d2-45df-4834-bbb4-68345cdd08c8"), "Merhaba {{RecipientName}},\n\nMevcut sorumluluklarım ve performansım doğrultusunda\nmaaş düzenlemesi hakkında görüşme talep ediyorum.\n\nUygun bir zaman belirleyebilirsek memnun olurum.\n\nSaygılarımla,\n{{SenderName}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3270), null, "Maaş Düzenlenmesi Görüşme Talebi", null },
                    { new Guid("d345b7fc-b44a-4e39-b453-923afab602e3"), "Merhaba {{RecipientName}},\n\n{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:\n\n{{StatusSummary}}\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3268), null, "Durum Güncellemesi", null },
                    { new Guid("ee9a07ce-6ca1-4649-8f81-7827c2589ee0"), "Merhaba {{RecipientName}},\n\n{{MeetingSubject}} hakkında görüşmek üzere\n{{ProposedDate}} tarihinde toplantı talep ediyorum.\n\nUygunluğunuzu rica ederim.\n\nİyi çalışmalar,\n{{SenderName}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3253), null, "Toplantı Talebi", null },
                    { new Guid("fce693ce-09d3-4035-b5ec-55eb51e0fe13"), "Merhaba {{RecipientName}},\n\n{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.\nYeni tarih ayrıca paylaşılacaktır.\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3255), null, "Toplantı Erteleme Bilgilendirmesi", null },
                    { new Guid("fd7c210c-0bb6-4ff1-b061-941b1e46e6d9"), "Merhaba {{RecipientName}},\n\n{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.\n\nGereğini rica ederim.\n\n{{SenderName}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 12, 27, 11, 16, 1, 926, DateTimeKind.Utc).AddTicks(3259), null, "Erişim Yetkisi Talebi", null }
                });
        }
    }
}
