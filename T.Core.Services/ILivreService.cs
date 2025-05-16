using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T.Core.Domaine; 


namespace T.Core.Services
{
    internal interface ILivreService
    {
        Livre GetLivre();
        IList<Livre> getlivredate(DateTime dd, DateTime df);

        IList<Categorie> getcategories(Status ss);
    }
}
