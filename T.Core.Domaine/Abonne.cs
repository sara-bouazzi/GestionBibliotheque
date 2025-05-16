using System;
using System.Collections.Generic;

namespace T.Core.Domaine
{
    public enum Status
    {
        Etudiant, Ensegnant, autre
    }

    public class Abonne
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Status status { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }

        public virtual IList<PretLivre> PretLivres { get; set; }
    }
}
