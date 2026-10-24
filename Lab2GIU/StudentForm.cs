using Lab2Modul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2GIU
{
    public partial class StudentForm : Form
    {
        private AnnonsRegister annonsRegister;
        private Student inloggadStudent;
        public StudentForm(Student inloggadStudent, AnnonsRegister annonsRegister)
        {
            InitializeComponent();
            this.inloggadStudent = inloggadStudent;
            this.annonsRegister = annonsRegister;
            label1.Text = "Välkommen, " + inloggadStudent.Förnamn + "!";
            VisaAnnonser();
        }
        private void VisaAnnonser(string sokText = "")
        {
            FirstAnnonser.Items.Clear();

            List<Annons> annonser =
                annonsRegister.HämtaTillgängligaAnnonser();

            foreach (Annons annons in annonser)
            {
                if (annons.Titel.IndexOf(
           sokText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    FirstAnnonser.Items.Add(
                    annons.Titel + " - " + annons.Pris + " kr");
                }
            }
          
        }

        private void btnSok_Click(object sender, EventArgs e)
        {
            VisaAnnonser(txtSok.Text.Trim());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void FirstAnnonser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            SkapaAnnonsForm skapaForm =
        new SkapaAnnonsForm(annonsRegister, inloggadStudent);

            skapaForm.ShowDialog();
            VisaAnnonser();
        }
    }
}
