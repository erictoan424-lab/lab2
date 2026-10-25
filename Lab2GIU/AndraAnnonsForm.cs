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
    public partial class AndraAnnonsForm : Form
    {
        private Annons valdAnnons;
        public AndraAnnonsForm(Annons valdAnnons)
        {
            InitializeComponent();

            this.valdAnnons = valdAnnons;

            txtTitel.Text = valdAnnons.Titel;
            txtPris.Text = valdAnnons.Pris.ToString();
        }

        private void AndraAnnonsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSparaÄndringar_Click(object sender, EventArgs e)
        {
            decimal nyttPris;

            if (string.IsNullOrWhiteSpace(txtTitel.Text) ||
                string.IsNullOrWhiteSpace(txtPris.Text))
            {
                MessageBox.Show("Fyll i både titel och pris.");
                return;
            }

            if (!decimal.TryParse(txtPris.Text, out nyttPris) || nyttPris < 0)
            {
                MessageBox.Show("Ange ett giltigt pris.");
                return;
            }

            valdAnnons.Titel = txtTitel.Text;
            valdAnnons.Pris = nyttPris;

            MessageBox.Show("Annonsen har uppdaterats!");
            this.Close();

        }
    }
}
