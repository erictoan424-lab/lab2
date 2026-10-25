using Lab2Modul;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
