// <auto-generated />
using System;
using Afelio_DemoEfCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Afelio_DemoEfCore.Domain.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    [Migration("20221213134658_Apply Configuration")]
    partial class ApplyConfiguration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Afelio_DemoEfCore.Entites.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categorie", (string)null);
                });

            modelBuilder.Entity("Afelio_DemoEfCore.Entites.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Anniversaire")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(384)
                        .HasColumnType("nvarchar(384)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasDefaultValueSql("''");

                    b.Property<int>("UtilisateurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Contact", (string)null);

                    b.HasCheckConstraint("CK_Contact_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
                });

            modelBuilder.Entity("Afelio_DemoEfCore.Entites.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Creation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATE")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(384)
                        .HasColumnType("nvarchar(384)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<byte[]>("Passwd")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("BINARY(64)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "UK_Utilisateur_Email")
                        .IsUnique();

                    b.ToTable("Utilisateur", (string)null);

                    b.HasCheckConstraint("CK_Utilisateur_Email", "(LEN(TRIM(Email)) > 4 AND Email LIKE '%@%.%')");
                });
#pragma warning restore 612, 618
        }
    }
}
