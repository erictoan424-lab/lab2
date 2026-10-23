using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class Kursbok : Annons
    {
        public string ISBN {  get; set; }
        public string Författare { get; set; } 
        public int Upplaga { get; set; }

    }
}
