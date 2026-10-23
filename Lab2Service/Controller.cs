using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2Modul;

namespace Lab2Service
{
    public class Controller
    {
        private AnnonsRegister annonsRegister;
        private StudentRegister studentRegister;

        public Controller(
            AnnonsRegister annonsRegister,
            StudentRegister studentRegister)
        {
            this.annonsRegister = annonsRegister;
            this.studentRegister = studentRegister;
        }

        public List<Annons> ListaAnnonser()
        {
            return annonsRegister.HämtaTillgängligaAnnonser();
        }

        public Annons VisaAnnons(int annonsId)
        {
            return annonsRegister.HittaAnnons(annonsId);
        }

        public Affär ReserveraAnnons(int annonsId, int köparId)
        {
            Annons annons = annonsRegister.HittaAnnons(annonsId);

            if (annons == null)
            {
                return null;
            }

            Student köpare = studentRegister.HittaStudent(köparId);

            if (köpare == null)
            {
                return null;
            }

            if (!annons.ÄrTillSalu())
            {
                return null;
            }

            Student säljare = annons.HämtaSäljare();

            if (köpare.Id == säljare.Id)
            {
                return null;
            }

            Affär affär = new Affär(annons, köpare);

            annons.SättStatus(AnnonsStatus.Reserverad);

            return affär;
        }
    }
}
