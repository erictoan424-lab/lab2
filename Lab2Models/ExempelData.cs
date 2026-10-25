using Lab2Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Models
{
    public static class ExempelData
    {
        public static void FyllStudenter(StudentRegister studentRegister)
        {
            Student student1 = new Student(
                1,
                "Jimmy",
                "Åkesson",
                "JimmyÅ@example.com",
                "0701111111",
                "test123"
            );

            Student student2 = new Student(
                2,
                "Alexander",
                "ISAK",
                "ISAK@example.com",
                "0702222222",
                "test1234"
            );

            studentRegister.LäggTill(student1);
            studentRegister.LäggTill(student2);
        }
        public static void FyllAnnonser(
    AnnonsRegister annonsRegister,
    StudentRegister studentRegister)
        {
            Student jimmy = studentRegister.HittaStudent(1);

            Kurs kurs = new Kurs(
                "DA101",
                "Programmering 1"
            );

            Kursbok bok = new Kursbok(
                annonsRegister.NästaId(),
                "C# för nybörjare",
                150m,
                Skick.BraSkick,
                jimmy,
                kurs,
                "9780000000001",
                "Exempelförfattare",
                2
            );

            annonsRegister.LäggTill(bok);
        }
    }
}
