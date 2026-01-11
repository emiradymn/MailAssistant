using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSentEmailEntityProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "FromEmail",
                table: "SentEmails",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "FromEmail",
                table: "SentEmails");

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
    }
}
