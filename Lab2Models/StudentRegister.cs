using System;
using System.Collections.Generic;
using System.IO;
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

        public Student HittaStudentViaEpost(string epost)
        {
            return studenter.FirstOrDefault(s => s.Epost == epost);
        }
        public int NästaId()
        {
            if (studenter.Count == 0)
            {
                return 1;
            }

            return studenter.Max(s => s.Id) + 1;
        }

        public bool FinnsEpost(string epost)
        {
            return HittaStudentViaEpost(epost) != null;
        }
        
        }
    }
