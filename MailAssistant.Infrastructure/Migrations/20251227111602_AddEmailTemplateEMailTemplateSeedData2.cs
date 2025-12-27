using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailTemplateEMailTemplateSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("026f23ee-06c4-4351-a0c4-1c91fa0245ec"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0714be02-9d81-4a2a-bb2e-3b9072dad2f4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("251332a3-6141-4195-893a-08636d78797a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("43a94882-3cd0-454a-8264-59cce2e8e415"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("45dd2caa-77fc-43a2-8066-6ff705e019a2"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("53fb2bc2-7167-494b-94e6-8da0e4b085c4"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("7cc530e3-22a6-45b3-9e67-9fcb3e520c01"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8c94654e-81f8-4fb1-a3d6-43154d7b0fac"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a7587451-9e5e-4793-b0a2-1a319e3c7e8a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("b7a4f7c0-01a9-42ee-b216-3667fa37aa49"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ca4a1b29-6690-47e1-b3f2-d554d151c95a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("f1163d10-a2d5-4449-ac34-ce2adb4edf05"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("026f23ee-06c4-4351-a0c4-1c91fa0245ec"), "Merhaba {{RecipientName}},\n\n{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.\nYeni tarih ayrıca paylaşılacaktır.\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9603), null, "Toplantı Erteleme Bilgilendirmesi", null },
                    { new Guid("0714be02-9d81-4a2a-bb2e-3b9072dad2f4"), "Merhaba {{RecipientName}},\n\n{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.\nEkte özgeçmişimi bilgilerinize sunuyorum.\n\nUygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.\n\nSaygılarımla,\n{{SenderName}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9575), null, "İş Başvurusu - {{PositionName}}", null },
                    { new Guid("251332a3-6141-4195-893a-08636d78797a"), "Merhaba {{RecipientName}},\n\n{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:\n\n{{StatusSummary}}\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9673), null, "Durum Güncellemesi – {{ProjectName}}", null },
                    { new Guid("43a94882-3cd0-454a-8264-59cce2e8e415"), "Merhaba {{RecipientName}},\n\n{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.\nSon teslim tarihi: {{DueDate}}\n\nBilginize sunarım.\n\n{{SenderName}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9671), null, "Görev Ataması – {{TaskTitle}}", null },
                    { new Guid("45dd2caa-77fc-43a2-8066-6ff705e019a2"), "Merhaba {{RecipientName}},\n\nMevcut sorumluluklarım ve performansım doğrultusunda\nmaaş düzenlemesi hakkında görüşme talep ediyorum.\n\nUygun bir zaman belirleyebilirsek memnun olurum.\n\nSaygılarımla,\n{{SenderName}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9675), null, "Maaş Düzenlenmesi Görüşme Talebi", null },
                    { new Guid("53fb2bc2-7167-494b-94e6-8da0e4b085c4"), "Merhaba {{SupportTeamName}},\n\n{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:\n\n{{IssueDescription}}\n\nDestek rica ederim.\n\n{{SenderName}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9663), null, "Teknik Destek Talebi – {{SystemName}}", null },
                    { new Guid("7cc530e3-22a6-45b3-9e67-9fcb3e520c01"), "Merhaba {{RecipientName}},\n\n{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren\nteklifinizi tarafımıza iletmenizi rica ederiz.\n\nİyi çalışmalar,\n{{SenderName}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9669), null, "Teklif Talebi – {{ServiceName}}", null },
                    { new Guid("8c94654e-81f8-4fb1-a3d6-43154d7b0fac"), "Merhaba {{RecipientName}},\n\n{{MeetingSubject}} hakkında görüşmek üzere\n{{ProposedDate}} tarihinde toplantı talep ediyorum.\n\nUygunluğunuzu rica ederim.\n\nİyi çalışmalar,\n{{SenderName}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9581), null, "Toplantı Talebi – {{MeetingSubject}}", null },
                    { new Guid("a7587451-9e5e-4793-b0a2-1a319e3c7e8a"), "Merhaba {{RecipientName}},\n\n{{InvoiceNumber}} numaralı faturaya ait ödemenin\ntarafımıza iletilmesini rica ederiz.\n\nBilgilerinize sunarız.\n\n{{SenderName}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9680), null, "Ödeme Talebi – {{InvoiceNumber}}", null },
                    { new Guid("b7a4f7c0-01a9-42ee-b216-3667fa37aa49"), "Merhaba {{RecipientName}},\n\nKarşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.\n\nUygunluğunuz halinde detayları görüşmek isteriz.\n\nSaygılarımızla,\n{{SenderName}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9667), null, "İş Birliği Teklifi", null },
                    { new Guid("ca4a1b29-6690-47e1-b3f2-d554d151c95a"), "Merhaba {{RecipientName}},\n\n{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.\nStaj kapsamında şirketinizde görev almak istiyorum.\n\nDeğerlendirmenizi rica ederim.\n\nSaygılarımla,\n{{SenderName}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9579), null, "Staj Başvurusu – {{DepartmentName}}", null },
                    { new Guid("f1163d10-a2d5-4449-ac34-ce2adb4edf05"), "Merhaba {{RecipientName}},\n\n{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.\n\nGereğini rica ederim.\n\n{{SenderName}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2025, 12, 24, 11, 45, 50, 893, DateTimeKind.Utc).AddTicks(9665), null, "Erişim Yetkisi Talebi – {{SystemName}}", null }
                });
        }
    }
}
