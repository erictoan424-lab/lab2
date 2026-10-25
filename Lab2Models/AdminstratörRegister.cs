using Lab2Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Models
{
    public class AdministratörRegister
    {
        private List<Administratör> administratörer =
            new List<Administratör>();

        public void LäggTill(Administratör administratör)
        {
            administratörer.Add(administratör);
        }

        public Administratör LoggaIn(string epost, string lösenord)
        {
            return administratörer.Find(a =>
                a.Epost == epost &&
                a.Lösenord == lösenord);
        }
    }
}
