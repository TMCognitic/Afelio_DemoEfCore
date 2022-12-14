using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afelio_DemoEfCore.Domain.Migrations
{
    public partial class AddDefaultFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Categorie_UtilisateurId",
                table: "Categorie",
                column: "UtilisateurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorie_Utilisateur_UtilisateurId",
                table: "Categorie",
                column: "UtilisateurId",
                principalTable: "Utilisateur",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorie_Utilisateur_UtilisateurId",
                table: "Categorie");

            migrationBuilder.DropIndex(
                name: "IX_Categorie_UtilisateurId",
                table: "Categorie");
        }
    }
}
