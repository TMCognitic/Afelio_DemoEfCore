using Afelio_DemoEfCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Afelio_DemoEfCore.Domain.Configurations
{
    internal class UtilisateurConfiguration : Configuration<Utilisateur>
    {
        public override void Configure(EntityTypeBuilder<Utilisateur> builder)
        {
            builder.ToTable("Utilisateur");

            builder.Property(u => u.Nom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(u => u.Prenom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(384);

            builder.Property(u => u.Passwd)
                .IsRequired()
                .HasColumnType("BINARY")
                .HasMaxLength(64)
                .HasConversion(new ValueConverter<string?, byte[]?>(s => s.Hash(), p => null));

            builder.Property(u => u.Creation)
                .IsRequired()
                .HasColumnType("DATE")
                .HasDefaultValueSql("GETDATE()");

            builder.HasCheckConstraint("CK_Utilisateur_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
            builder.HasIndex(u => new { u.Nom, u.Prenom }, "UK_Utilisateur_FullName")
                .IsUnique();

            builder.HasIndex(u => u.Email, "UK_Utilisateur_Email")
                .IsUnique();

            builder.HasData(
                new Utilisateur() { Id = 1, Nom = "Doe", Prenom = "John", Email = "john.doe@test.com", Passwd = "Test1234=" }
                );
        }
    }
}
