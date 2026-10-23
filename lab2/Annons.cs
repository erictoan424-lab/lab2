using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
  
        public abstract class Annons
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public decimal Pris { get; set; }
        public Skick Skick { get; set; }
        public DateTime Publiceringsdatum { get; set; }
        public AnnonsStatus Status { get; set; }

        public Student Säljare { get; set; }
        public Kurs Kurs { get; set; }

        public Annons(
            int id,
            string titel,
        decimal pris,
            Skick skick,
            Student säljare,
            Kurs kurs)
        {
            Id = id;
            Titel = titel;
            Pris = pris;
            Skick = skick;
            Säljare = säljare;
            Kurs = kurs;

            Publiceringsdatum = DateTime.Now;
            Status = AnnonsStatus.TillSalu;
        }

        public bool ÄrTillSalu()
        {
            return Status == AnnonsStatus.TillSalu;
        }

        public Student HämtaSäljare()
        {
            return Säljare;
        }

        public void SättStatus(AnnonsStatus status)
        {
            Status = status;
        }
    }

}
