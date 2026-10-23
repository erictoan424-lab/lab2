using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class AnnonsRegister
    {
        private List<Annons> annonser = new List<Annons>();

        public void LäggTill(Annons annons)
        {
            annonser.Add(annons);
        }

        public List<Annons> HämtaTillgängligaAnnonser()
        {
            return annonser.FindAll(a => a.ÄrTillSalu());
        }

        public Annons HittaAnnons(int annonsId)
        {
            return annonser.Find(a => a.Id == annonsId);
        }
    }
}
