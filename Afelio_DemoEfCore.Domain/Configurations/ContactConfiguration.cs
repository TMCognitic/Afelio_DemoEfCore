using Afelio_DemoEfCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afelio_DemoEfCore.Domain.Configurations
{
    internal class ContactConfiguration : Configuration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            builder.Property(c => c.Nom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(c => c.Prenom)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(384);

            builder.Property(c => c.Anniversaire)
                .IsRequired();

            builder.Property(c => c.Tel)
                .IsRequired()
                .HasMaxLength(30)
                .HasDefaultValueSql("''");

            builder.HasCheckConstraint("CK_Contact_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
        }
    }
}
