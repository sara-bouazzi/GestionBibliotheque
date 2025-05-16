using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Core.Domaine;
using T.Core.Interfaces;


namespace T.Core.Services
{
    public class LivreService : Service<Livre>, ILivreService
    {
        public LivreService(IUnitOfWork uow) : base(uow)
        {
        }

        public IList<Categorie> getcategories(Status ss)
        {
            return GetAll()
                .Where(h=>h.PretLivres
                .Any(h=>h.MyAbonne.status == ss))
                .Select(h=>h.MyCategorie)
                .Distinct().ToList();
                 
        }

        public Livre GetLivre()
        {
            return GetAll().OrderByDescending(h => h.PretLivres.Count).First();
        }

        public IList<Livre> getlivredate(DateTime dd, DateTime df)
        {
            return GetAll()
                .Where(h=>h.PretLivres
                .Any(h=>h.DateDebut>=dd && h.DateFin<=df))
                .ToList();
                ;
        }
    }
}
