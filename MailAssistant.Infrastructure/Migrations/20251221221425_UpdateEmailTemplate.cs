using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MailAssistant.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmailTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EmailTemplates",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "EmailTemplates",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplates_UserId",
                table: "EmailTemplates",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailTemplates_AspNetUsers_UserId",
                table: "EmailTemplates",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailTemplates_AspNetUsers_UserId",
                table: "EmailTemplates");

            migrationBuilder.DropIndex(
                name: "IX_EmailTemplates_UserId",
                table: "EmailTemplates");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EmailTemplates");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EmailTemplates");
        }
    }
}
