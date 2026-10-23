using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Modul
{
    public class StudentRegister
    {
        private List<Student> studenter = new List<Student>();

        public void LäggTill(Student student)
        {
            studenter.Add(student);
        }

        public Student HittaStudent(int studentId)
        {
            return studenter.Find(s => s.Id == studentId);
        }

        public Student? HittaStudentViaEpost(string epost)
        {
            return studenter.FirstOrDefault(s => s.Epost == epost);
        }
    }
}
