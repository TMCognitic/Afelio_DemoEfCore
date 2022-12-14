using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Afelio_DemoEfCore.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Afelio_DemoEfCore.Domain.Configurations
{
    internal class CategorieConfiguration : Configuration<Categorie>
    {
        public override void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");

            builder.Property(e => e.Nom)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
