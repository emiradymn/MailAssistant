using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSentMailsPropSingature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("20ef3cf7-43d4-4143-940a-e04ad8954737"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("31325b91-5e79-4462-a041-64774fde1002"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("33a66258-af83-4ad3-9b7f-b21b672ee17f"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("3c958f99-3dc8-4293-9c90-4c352b4c6445"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("4731fd7a-0e74-4131-bd68-cf8ce8f9784b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("68dff8d0-ab4c-4d1a-9d6f-00b32b0be52c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("99bd5f34-f991-4a9d-ba57-76d94a4a5e23"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ac2ed153-3482-40c2-bcfe-be7ed847a646"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ace3a9b5-2343-414a-85e6-b7e119852f3c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("cc104641-03ed-4d23-8d61-237c7ecf6fb1"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("e4a6bd66-a6b4-4f18-be59-acf3f1b9bd48"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("f62fa289-4938-437d-a306-a9113c3d5ea2"));

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "SentEmails",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CategoryId", "CreatedAt", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cd1ae79-1977-4ab0-8b94-581f6ab5a93a"), "Merhaba {{RecipientName}},\n\n{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.\nEkte özgeçmişimi bilgilerinize sunuyorum.\n\nUygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8659), null, "İş Başvurusu", null },
                    { new Guid("1e8aac36-3837-445b-a340-c70868ce2cd3"), "Merhaba {{RecipientName}},\n\n{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.\nStaj kapsamında şirketinizde görev almak istiyorum.\n\nDeğerlendirmenizi rica ederim.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8684), null, "Staj Başvurusu", null },
                    { new Guid("234c722c-d717-4d42-ba70-f3692841b121"), "Merhaba {{RecipientName}},\n\nMevcut sorumluluklarım ve performansım doğrultusunda\nmaaş düzenlemesi hakkında görüşme talep ediyorum.\n\nUygun bir zaman belirleyebilirsek memnun olurum.\n\nSaygılarımla,\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8703), null, "Maaş Düzenlenmesi Görüşme Talebi", null },
                    { new Guid("2c97783a-e9af-461f-a770-ebaaa30ee7f8"), "Merhaba {{RecipientName}},\n\n{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.\nSon teslim tarihi: {{DueDate}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8697), null, "Görev Ataması", null },
                    { new Guid("7dad2fc5-337f-49c7-9802-6ec00c123189"), "Merhaba {{RecipientName}},\n\n{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren\nteklifinizi tarafımıza iletmenizi rica ederiz.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8695), null, "Teklif Talebi", null },
                    { new Guid("7e6fdf89-1f19-4234-a7a7-559494caf044"), "Merhaba {{RecipientName}},\n\n{{MeetingSubject}} hakkında görüşmek üzere\n{{ProposedDate}} tarihinde toplantı talep ediyorum.\n\nUygunluğunuzu rica ederim.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8686), null, "Toplantı Talebi", null },
                    { new Guid("8dbfbe1b-9929-4863-81a7-d380b7d13398"), "Merhaba {{RecipientName}},\n\n{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.\n\nGereğini rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8691), null, "Erişim Yetkisi Talebi", null },
                    { new Guid("a77d40ba-5c02-46aa-b446-74d780ced0d1"), "Merhaba {{SupportTeamName}},\n\n{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:\n\n{{IssueDescription}}\n\nDestek rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8690), null, "Teknik Destek Talebi ", null },
                    { new Guid("b9c29357-3538-4f80-8e89-128be7f1935c"), "Merhaba {{RecipientName}},\n\n{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.\nYeni tarih ayrıca paylaşılacaktır.\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8688), null, "Toplantı Erteleme Bilgilendirmesi", null },
                    { new Guid("c2078de1-92f6-41b1-aa1e-e3534196915b"), "Merhaba {{RecipientName}},\n\n{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:\n\n{{StatusSummary}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8701), null, "Durum Güncellemesi", null },
                    { new Guid("c63d1ef0-c5c2-4da5-92db-019deada6dc7"), "Merhaba {{RecipientName}},\n\n{{InvoiceNumber}} numaralı faturaya ait ödemenin\ntarafımıza iletilmesini rica ederiz.\n\nBilgilerinize sunarız.\n\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8705), null, "Ödeme Talebi", null },
                    { new Guid("ddba7528-ceda-44d7-94c1-28010ea8ac84"), "Merhaba {{RecipientName}},\n\nKarşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.\n\nUygunluğunuz halinde detayları görüşmek isteriz.\n\nSaygılarımızla,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 13, 14, 8, 7, 190, DateTimeKind.Utc).AddTicks(8693), null, "İş Birliği Teklifi", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("0cd1ae79-1977-4ab0-8b94-581f6ab5a93a"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("1e8aac36-3837-445b-a340-c70868ce2cd3"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("234c722c-d717-4d42-ba70-f3692841b121"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("2c97783a-e9af-461f-a770-ebaaa30ee7f8"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("7dad2fc5-337f-49c7-9802-6ec00c123189"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("7e6fdf89-1f19-4234-a7a7-559494caf044"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("8dbfbe1b-9929-4863-81a7-d380b7d13398"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("a77d40ba-5c02-46aa-b446-74d780ced0d1"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("b9c29357-3538-4f80-8e89-128be7f1935c"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c2078de1-92f6-41b1-aa1e-e3534196915b"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("c63d1ef0-c5c2-4da5-92db-019deada6dc7"));

            migrationBuilder.DeleteData(
                table: "EmailTemplates",
                keyColumn: "Id",
                keyValue: new Guid("ddba7528-ceda-44d7-94c1-28010ea8ac84"));

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "SentEmails");

            migrationBuilder.InsertData(
                table: "EmailTemplates",
                columns: new[] { "Id", "Body", "CategoryId", "CreatedAt", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("20ef3cf7-43d4-4143-940a-e04ad8954737"), "Merhaba {{RecipientName}},\n\n{{InvoiceNumber}} numaralı faturaya ait ödemenin\ntarafımıza iletilmesini rica ederiz.\n\nBilgilerinize sunarız.\n\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5978), null, "Ödeme Talebi", null },
                    { new Guid("31325b91-5e79-4462-a041-64774fde1002"), "Merhaba {{RecipientName}},\n\n{{TaskTitle}} başlıklı görev tarafınıza atanmıştır.\nSon teslim tarihi: {{DueDate}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5968), null, "Görev Ataması", null },
                    { new Guid("33a66258-af83-4ad3-9b7f-b21b672ee17f"), "Merhaba {{RecipientName}},\n\nKarşılıklı fayda sağlayacak bir iş birliği fırsatını değerlendirmek isteriz.\n\nUygunluğunuz halinde detayları görüşmek isteriz.\n\nSaygılarımızla,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5963), null, "İş Birliği Teklifi", null },
                    { new Guid("3c958f99-3dc8-4293-9c90-4c352b4c6445"), "Merhaba {{RecipientName}},\n\n{{ProjectName}} projesine ait güncel durum aşağıdaki gibidir:\n\n{{StatusSummary}}\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5970), null, "Durum Güncellemesi", null },
                    { new Guid("4731fd7a-0e74-4131-bd68-cf8ce8f9784b"), "Merhaba {{RecipientName}},\n\nMevcut sorumluluklarım ve performansım doğrultusunda\nmaaş düzenlemesi hakkında görüşme talep ediyorum.\n\nUygun bir zaman belirleyebilirsek memnun olurum.\n\nSaygılarımla,\n{{Signature}}", new Guid("66666666-6666-6666-6666-666666666666"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5973), null, "Maaş Düzenlenmesi Görüşme Talebi", null },
                    { new Guid("68dff8d0-ab4c-4d1a-9d6f-00b32b0be52c"), "Merhaba {{RecipientName}},\n\n{{ServiceName}} hizmetiniz için fiyat ve kapsam bilgisi içeren\nteklifinizi tarafımıza iletmenizi rica ederiz.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5965), null, "Teklif Talebi", null },
                    { new Guid("99bd5f34-f991-4a9d-ba57-76d94a4a5e23"), "Merhaba {{RecipientName}},\n\n{{SystemName}} için {{RequestedPermission}} yetkisine ihtiyacım bulunmaktadır.\n\nGereğini rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5960), null, "Erişim Yetkisi Talebi", null },
                    { new Guid("ac2ed153-3482-40c2-bcfe-be7ed847a646"), "Merhaba {{RecipientName}},\n\n{{UniversityName}} {{DepartmentName}} bölümünde öğrenim görmekteyim.\nStaj kapsamında şirketinizde görev almak istiyorum.\n\nDeğerlendirmenizi rica ederim.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5938), null, "Staj Başvurusu", null },
                    { new Guid("ace3a9b5-2343-414a-85e6-b7e119852f3c"), "Merhaba {{SupportTeamName}},\n\n{{SystemName}} üzerinde aşağıdaki sorunla karşılaşmaktayım:\n\n{{IssueDescription}}\n\nDestek rica ederim.\n\n{{Signature}}", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5958), null, "Teknik Destek Talebi ", null },
                    { new Guid("cc104641-03ed-4d23-8d61-237c7ecf6fb1"), "Merhaba {{RecipientName}},\n\n{{OriginalDate}} tarihinde planlanan toplantı ertelenmiştir.\nYeni tarih ayrıca paylaşılacaktır.\n\nBilginize sunarım.\n\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5955), null, "Toplantı Erteleme Bilgilendirmesi", null },
                    { new Guid("e4a6bd66-a6b4-4f18-be59-acf3f1b9bd48"), "Merhaba {{RecipientName}},\n\n{{MeetingSubject}} hakkında görüşmek üzere\n{{ProposedDate}} tarihinde toplantı talep ediyorum.\n\nUygunluğunuzu rica ederim.\n\nİyi çalışmalar,\n{{Signature}}", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5941), null, "Toplantı Talebi", null },
                    { new Guid("f62fa289-4938-437d-a306-a9113c3d5ea2"), "Merhaba {{RecipientName}},\n\n{{PositionName}} pozisyonu için başvuruda bulunmak istiyorum.\nEkte özgeçmişimi bilgilerinize sunuyorum.\n\nUygun görmeniz halinde görüşme yapmaktan memnuniyet duyarım.\n\nSaygılarımla,\n{{Signature}}", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2026, 1, 7, 13, 6, 31, 605, DateTimeKind.Utc).AddTicks(5934), null, "İş Başvurusu", null }
                });
        }
    }
}
