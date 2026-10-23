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

        public Kursbok(int id,string titel,decimal pris,Skick skick,Student säljare,Kurs kurs,string isbn,string författtare,int upplaga) : base(id, titel, pris, skick, säljare, kurs)
        {
            ISBN = isbn;
            Författare = författtare;
            Upplaga = upplaga;
        }

    }
}
