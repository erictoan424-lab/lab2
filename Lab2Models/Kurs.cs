using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class Kurs
    {
        public string Kod { get; set; }
        public string Namn { get; set; }

        public Kurs(string kod, string namn)
        {
            Kod = kod;
            Namn = namn;
        }
    }
}
