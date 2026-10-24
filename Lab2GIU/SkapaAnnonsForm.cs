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
    public partial class SkapaAnnonsForm : Form
    {
        private AnnonsRegister annonsRegister;
        private Student inloggadStudent;

        public SkapaAnnonsForm(AnnonsRegister annonsRegister,
            Student inloggadStudent)

        {
            InitializeComponent();

            this.annonsRegister = annonsRegister;
            this.inloggadStudent = inloggadStudent;

            cmbSkick.Items.Add("Nyskick");
            cmbSkick.Items.Add("Bra skick");
            cmbSkick.Items.Add("Slitet");

            cmbSkick.SelectedIndex = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SkapaAnnonsForm_Load(object sender, EventArgs e)
        {

        }

        private void labelPris_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUpplaga_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSkapaAnnons_Click(object sender, EventArgs e)
        {
            decimal pris;
            int upplaga;

            if (string.IsNullOrWhiteSpace(txtTitel.Text) ||
        string.IsNullOrWhiteSpace(txtPris.Text) ||
        string.IsNullOrWhiteSpace(txtISBN.Text) ||
        string.IsNullOrWhiteSpace(txtFörfattare.Text) ||
        string.IsNullOrWhiteSpace(txtUpplaga.Text) ||
        string.IsNullOrWhiteSpace(txtKurskod.Text) ||
        string.IsNullOrWhiteSpace(txtKursnamn.Text))
            {
                MessageBox.Show("Fyll i alla fält.");
                return;
            }

            if (!decimal.TryParse(txtPris.Text, out pris) ||
                !int.TryParse(txtUpplaga.Text, out upplaga))
            {
                MessageBox.Show("Kontrollera pris och upplaga.");
                return;
            }

            Skick skick = (Skick)cmbSkick.SelectedIndex;

            Kurs kurs = new Kurs(
                txtKurskod.Text,
                txtKursnamn.Text
            );

            Kursbok kursbok = new Kursbok(annonsRegister.NästaId(),
                
                txtTitel.Text,
                pris,
                skick,
                inloggadStudent,
                kurs,
                txtISBN.Text,
                txtFörfattare.Text,
                upplaga
            );

            annonsRegister.LäggTill(kursbok);

            MessageBox.Show("Annonsen har skapats!");

            this.Close();
        }
    }
}
