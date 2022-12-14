using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoEfCore.Entites
{
#nullable disable
    public class Categorie
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int UtilisateurId { get; set; }

        public Utilisateur Utilisateur { get; set; }
    }
#nullable enable
}
