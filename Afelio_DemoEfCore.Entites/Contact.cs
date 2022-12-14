using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afelio_DemoEfCore.Entites
{
#nullable disable
    public class Contact
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public DateTime Anniversaire { get; set; }
        public string Tel { get; set; }
        public int UtilisateurId { get; set; }
    }
#nullable enable
}
