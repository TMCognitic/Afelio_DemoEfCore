using Afelio_DemoEfCore.Domain.Configurations;
using Afelio_DemoEfCore.Entites;
using Microsoft.EntityFrameworkCore;

namespace Afelio_DemoEfCore.Domain
{
    public class ContactDbContext : DbContext
    {
        public DbSet<Utilisateur> Utilisateurs { get { return Set<Utilisateur>(); } }
        public DbSet<Categorie> Categories { get { return Set<Categorie>(); } }
        public DbSet<Contact> Contacts { get { return Set<Contact>(); } }

        //Configure le DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestContact;Integrated Security=True;");
        }

        //Configurer les entités
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Ajoute la configuration spécifié dans la classe CategorieConfiguration
            //pour la configuration de la Categorie
            modelBuilder.ApplyConfiguration(new CategorieConfiguration());
            //Voir au dessus et Google Trad
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            //Voir au dessus et Google Trad
            modelBuilder.ApplyConfiguration(new UtilisateurConfiguration());
        }
    }
}