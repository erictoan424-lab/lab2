using System.Collections.Generic;
using System.Linq;
using Lab2Modul; 

namespace Lab2Service
{
    public class InloggningsService
    {
        private StudentRegister studentregister;
        private List<Administratör> administratörer;

        public InloggningsService(
            StudentRegister studentregister,
            List<Administratör> administratörer)
        {
            this.studentregister = studentregister;
            this.administratörer = administratörer;
        }

        public bool LoggaIn(string epost, string lösenord)
        {
            bool studentFinns = studentregister
                .HittaStudentViaEpost(epost)?.Lösenord == lösenord;

            bool adminFinns = administratörer.Any(a =>
                a.Epost == epost && a.Lösenord == lösenord);

            return studentFinns || adminFinns;
        }
    }
}
