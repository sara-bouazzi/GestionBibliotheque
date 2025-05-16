using System;

namespace T.Core.Domaine
{
    public class PretLivre
    {
        public DateTime DateFin { get; set; }
        public DateTime DateDebut { get; set; }

        public int AbonneFk { get; set; }
        public Abonne MyAbonne { get; set; }

        public int LivreFk { get; set; }
        public Livre MyLivre { get; set; }
    }
}
