using Lab2Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Models
{
    public class KursRegister
    {
        private List<Kurs> kurser = new List<Kurs>();

        public void LäggTill(Kurs kurs)
        {
            kurser.Add(kurs);
        }

        public List<Kurs> HämtaAllaKurser()
        {
            return new List<Kurs>(kurser);
        }
        public bool ÄndraKurs(string kurskod, string nyttNamn)
        {
            Kurs kurs = kurser.FirstOrDefault(k => k.Kod == kurskod);

            if (kurs == null)
            {
                return false;
            }
            kurs.Namn = nyttNamn;
            return true;
        }
        public bool TaBortKurs(string kurskod)
        {
            Kurs kurs = kurser.FirstOrDefault(k => k.Kod == kurskod);
            
            if (kurs == null)
            {
                return false;
            }
            kurser.Remove(kurs);
            return true;
        }
    }
}
