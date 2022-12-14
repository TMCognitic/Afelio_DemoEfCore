using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afelio_DemoEfCore.Domain.Migrations
{
    public partial class ApplyAddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Utilisateur",
                columns: new[] { "Id", "Email", "Nom", "Passwd", "Prenom" },
                values: new object[] { 1, "john.doe@test.com", "Doe", new byte[] { 209, 8, 184, 29, 238, 159, 243, 131, 245, 125, 87, 195, 157, 128, 220, 245, 197, 115, 160, 229, 200, 218, 169, 68, 218, 14, 138, 12, 110, 174, 176, 245, 243, 72, 117, 158, 72, 123, 185, 209, 35, 187, 100, 182, 129, 174, 192, 152, 170, 196, 237, 237, 34, 73, 171, 138, 143, 167, 216, 129, 127, 252, 166, 205 }, "John" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Utilisateur",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
