using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailTemplateCategorySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmailTemplateCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "İnsan kaynakları, işe alım ve kariyer süreçleri", "İK & Kariyer" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Toplantı daveti, hatırlatma ve organizasyon e-postaları", "Toplantı" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Teknik süreçler, bakım ve operasyonel bilgilendirmeler", "Teknik Operasyon" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Kurumsal iş birlikleri ve partner iletişimleri", "İş Birliği" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Genel iletişim, duyuru ve bilgilendirme e-postaları", "İletişim" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Faturalama, ödeme ve finansal bilgilendirmeler", "Finans" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "EmailTemplateCategories",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));
        }
    }
}
