using Lab2Modul;
using Lab2Service;
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
        private List<Annons> visadeAnnonser = new List<Annons>();
        private Controller controller;
        private Affär reserveradAffär;
        public StudentForm(Student inloggadStudent, AnnonsRegister annonsRegister, StudentRegister studentRegister)
        {
            InitializeComponent();
            this.inloggadStudent = inloggadStudent;
            this.annonsRegister = annonsRegister;

            controller = new Controller(annonsRegister, studentRegister);

            label1.Text = "Välkommen, " + inloggadStudent.Förnamn + "!";
            VisaAnnonser();
        }
        private void VisaAnnonser(string sokText = "")
        {
            FirstAnnonser.Items.Clear();
            visadeAnnonser.Clear();

            List<Annons> annonser =
                annonsRegister.HämtaTillgängligaAnnonser();

            foreach (Annons annons in annonser)
            {
                if (annons.Titel.IndexOf(
           sokText, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    visadeAnnonser.Add(annons);

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

        private void btnSok_Click_1(object sender, EventArgs e)
        {
            VisaAnnonser(txtSok.Text.Trim());
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReservera_Click(object sender, EventArgs e)
        {
            if (FirstAnnonser.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            Annons valdAnnons =
                visadeAnnonser[FirstAnnonser.SelectedIndex];

            reserveradAffär = controller.ReserveraAnnons(
                valdAnnons.Id,
                inloggadStudent.Id);

            if (reserveradAffär == null)
            {
                MessageBox.Show(
                    "Annonsen kunde inte reserveras. " +
                    "Kontrollera att du inte försöker reservera din egen annons.");
                return;
            }

            MessageBox.Show("Annonsen har reserverats!");

            VisaAnnonser(txtSok.Text.Trim());
        }

        private void btnBekräftaKöp_Click(object sender, EventArgs e)
        {
            if (reserveradAffär == null)
            {
                MessageBox.Show("Du har ingen reserverad affär att bekräfta.");
                return;
            }

            bool lyckades = controller.BekräftaKöp(reserveradAffär);

            if (lyckades)
            {
                MessageBox.Show("Köpet har bekräftats!");

                reserveradAffär = null;

                VisaAnnonser(txtSok.Text.Trim());
            }
            else
            {
                MessageBox.Show("Köpet kunde inte bekräftas.");
            }

        }

        private void btnMinaAnnonser_Click(object sender, EventArgs e)
        {
            List<Annons> minaAnnonser =
       annonsRegister.HämtaStudentensAnnonser(inloggadStudent.Id);

            FirstAnnonser.Items.Clear();
            visadeAnnonser.Clear();

            foreach (Annons annons in minaAnnonser)
            {
                visadeAnnonser.Add(annons);

                FirstAnnonser.Items.Add(
                    annons.Titel + " - " + annons.Pris + " kr (" + annons.Status + ")");
            }

        }

        private void btnAndraAnnons_Click(object sender, EventArgs e)
        {
            if (FirstAnnonser.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            Annons valdAnnons =
                visadeAnnonser[FirstAnnonser.SelectedIndex];

            if (valdAnnons.Säljare.Id != inloggadStudent.Id)
            {
                MessageBox.Show("Du kan bara ändra dina egna annonser.");
                return;
            }

            if (valdAnnons.Status != AnnonsStatus.TillSalu)
            {
                MessageBox.Show("Du kan bara ändra annonser som är till salu.");
                return;
            }

            AndraAnnonsForm andraForm = new AndraAnnonsForm(valdAnnons);
            andraForm.ShowDialog();

            VisaAnnonser(txtSok.Text.Trim());

        }

        private void btnTaBortAnnons_Click(object sender, EventArgs e)
        {
            if (FirstAnnonser.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            Annons valdAnnons =
                visadeAnnonser[FirstAnnonser.SelectedIndex];

            if (valdAnnons.Säljare.Id != inloggadStudent.Id)
            {
                MessageBox.Show("Du kan bara ta bort dina egna annonser.");
                return;
            }

            if (valdAnnons.Status != AnnonsStatus.TillSalu)
            {
                MessageBox.Show("Du kan bara ta bort annonser som är till salu.");
                return;
            }

            DialogResult svar = MessageBox.Show(
                "Är du säker på att du vill ta bort annonsen?",
                "Bekräfta borttagning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (svar != DialogResult.Yes)
            {
                return;
            }

            annonsRegister.TaBort(valdAnnons);

            MessageBox.Show("Annonsen har tagits bort.");

            VisaAnnonser(txtSok.Text.Trim());

        }
    }
}
