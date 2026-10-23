using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
   
    
        public class Student
        {
            public int Id { get; set; }
            public string Förnamn { get; set; }
            public string Efternamn { get; set; }
            public string Epost { get; set; }
            public string Telefonnummer { get; set; }

            public string Lösenord { get; set; }

            public Student(
                int id,
                string förnamn,
                string efternamn,
                string epost,
                string telefonnummer,
                string lösenord)
               
            {
                Id = id;
                Förnamn = förnamn;
                Efternamn = efternamn;
                Epost = epost;
                Telefonnummer = telefonnummer;
                Lösenord = lösenord;
            }
        }
}
