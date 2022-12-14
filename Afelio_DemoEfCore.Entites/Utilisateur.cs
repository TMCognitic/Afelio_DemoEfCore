namespace Afelio_DemoEfCore.Entites
{
#nullable disable
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string? Passwd { get; set; }
        public DateTime Creation { get; set; }

        public virtual ICollection<Categorie> Categories { get; set; } = new List<Categorie>();
    }
#nullable enable
}