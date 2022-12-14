using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afelio_DemoEfCore.Domain.Migrations
{
    public partial class ApplyConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(384)", maxLength: 384, nullable: false),
                    Anniversaire = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "''"),
                    UtilisateurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.CheckConstraint("CK_Contact_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(384)", maxLength: 384, nullable: false),
                    Passwd = table.Column<byte[]>(type: "BINARY(64)", maxLength: 64, nullable: false),
                    Creation = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                    table.CheckConstraint("CK_Utilisateur_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
                });

            migrationBuilder.CreateIndex(
                name: "UK_Utilisateur_Email",
                table: "Utilisateur",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
