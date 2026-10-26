using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2Service;
using Lab2Modul;
using Lab2Models;

namespace Lab2GIU
{
    public partial class Form1 : Form
    { 
        private StudentRegister studentRegister = new StudentRegister();
        private AnnonsRegister annonsRegister = new AnnonsRegister();
        private List<Administratör> administratör = new List<Administratör>();
        private InloggningsService inloggningsService;
        private KursRegister kursRegister = new KursRegister();

        public Form1()
        {
            InitializeComponent();

            kursRegister.LäggTill(new Kurs("MA100", "Matematik"));
            kursRegister.LäggTill(new Kurs("PR200", "Programmering"));
            kursRegister.LäggTill(new Kurs("SV300", "Svenska"));

            ExempelData.FyllStudenter(studentRegister);
            ExempelData.FyllAnnonser(annonsRegister, studentRegister);

            administratör.Add(new Administratör
            {
                Förnamn = "Eric",
                Efternamn = "Tran",
                Epost = "Eric@test.se",
                Telefonnummer = "0701234567",
                Lösenord = "123"
            });

            inloggningsService = new InloggningsService(studentRegister, administratör);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string epost = txtEpost.Text;
            string lösenord = txtLosenord.Text;

            bool lyckades = inloggningsService.LoggaIn(epost, lösenord);

            if (!lyckades)
            {
                MessageBox.Show("Fel e-post eller lösenord!");
                return;
            }
            Student student = studentRegister.HittaStudentViaEpost(epost);

            if (student != null)
            {
                StudentForm studentForm =
            new StudentForm(student, annonsRegister, studentRegister,kursRegister);

                studentForm.Show();
                this.Hide();
                return;
            }
            Administratör admin = administratör.Find(a => a.Epost == epost);
            if (admin != null)
            {
                AdminForm adminForm = new AdminForm(annonsRegister,kursRegister);
                adminForm.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Förnamn = textBox1.Text.Trim();
            string Efternamn = textBox2.Text.Trim();
            string Telefonnummer = textBox3.Text.Trim();
            string epost = txtEpost.Text.Trim();
            string lösenord = txtLosenord.Text;

            if (string.IsNullOrWhiteSpace(Förnamn) ||
                string.IsNullOrWhiteSpace(Efternamn) ||
                string.IsNullOrWhiteSpace(Telefonnummer) ||
                string.IsNullOrWhiteSpace(epost) ||
                string.IsNullOrWhiteSpace(lösenord))
            {
                MessageBox.Show(
                    "Fyll i förnamn, efternamn, e-post och lösenord för att registrera dig.");
                return;
            }

            if (studentRegister.FinnsEpost(epost))
            {
                MessageBox.Show("Den här e-postadressen är redan registrerad!");
                return;
            }

            Student nyStudent = new Student(
                studentRegister.NästaId(),
                Förnamn, Efternamn, epost, Telefonnummer, lösenord);

            studentRegister.LäggTill(nyStudent);
            

            MessageBox.Show(
                "Registreringen lyckades.");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            txtEpost.Clear();
            txtLosenord.Clear();

        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLosenord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    