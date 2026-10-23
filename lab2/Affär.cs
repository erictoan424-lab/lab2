using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    
    public class Affär
    {
        public Annons Annons { get; set; }
        public Student Köpare { get; set; }
        public DateTime Reservationsdatum { get; set; }
        public AffärStatus Status { get; set; }

        public Affär(Annons annons, Student köpare)
        {
            Annons = annons;
            Köpare = köpare;
            Reservationsdatum = DateTime.Now;
            Status = AffärStatus.Reserverad;
        }
    }
}
