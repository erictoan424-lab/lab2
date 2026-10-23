using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class Kompendium : Annons
    {
        public int AntalSidor { get; set; }
        public int Utgivningsår {  get; set; }

        public Kompendium(int id,string titel,decimal pris,Skick skick,Student säljare,Kurs kurs,int antalSidor,int utgivningsår): base(id, titel, pris, skick, säljare, kurs)
        {
            AntalSidor = antalSidor;
            Utgivningsår = utgivningsår;
        }

    }
}
