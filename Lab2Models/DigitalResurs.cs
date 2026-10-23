using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class DigitalResurs : Annons
    {
        public string Filformat {  get; set; }
        public string Leveranssätt {  get; set; }

        public DigitalResurs(
            int id,
            string titel,
            decimal pris,
            Skick skick,
            Student student,
            Kurs kurs,
            string filformat,
            string leveranssätt)
            :base(id,titel, pris, skick, student, kurs)
        {
            Filformat = filformat;
            Leveranssätt = leveranssätt;
        }

    }
}
