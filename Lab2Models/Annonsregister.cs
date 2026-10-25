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

        public void TaBort(Annons annons)
        {
            annonser.Remove(annons);
        }

        public List<Annons> HämtaTillgängligaAnnonser()
        {
            return annonser.FindAll(a => a.ÄrTillSalu());
        }
        public List<Annons> HämtaStudentensAnnonser(int studentId)
        {
            return annonser.FindAll(a => a.Säljare.Id == studentId);
        }

        public Annons HittaAnnons(int annonsId)
        {
            return annonser.Find(a => a.Id == annonsId);
        }
        public int NästaId()
        {
            if (annonser.Count == 0)
            {
                return 1;
            }

            return annonser.Max(a => a.Id) + 1;
        }
    }   
}
