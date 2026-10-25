using Lab2Models;
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
    public partial class HanteraKurserForm : Form
    {
        private KursRegister kursRegister;
        public HanteraKurserForm()
        {
            InitializeComponent();
            kursRegister = new KursRegister();
            VisaKurser();
        }
        private void VisaKurser()
        {
            lstKurser.Items.Clear();

            foreach (Kurs kurs in kursRegister.HämtaAllaKurser())
            {
                lstKurser.Items.Add(
                    kurs.Kod + " - " + kurs.Namn);
            }
        }
        private void btnLäggTillKurs_Click(object sender, EventArgs e)
        {
            string kurskod = txtKurskod.Text.Trim();
            string kursnamn = txtKursnamn.Text.Trim();

            if (string.IsNullOrWhiteSpace(kurskod) ||
                string.IsNullOrWhiteSpace(kursnamn))
            {
                MessageBox.Show("Fyll i både kurskod och kursnamn.");
                return;
            }

            foreach (Kurs kurs in kursRegister.HämtaAllaKurser())
            {
                if (kurs.Kod.Equals(
                        kurskod, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Kurskoden finns redan.");
                    return;
                }
            }

            kursRegister.LäggTill(new Kurs(kurskod, kursnamn));

            VisaKurser();

            txtKurskod.Clear();
            txtKursnamn.Clear();

            MessageBox.Show("Kursen har lagts till.");
        }

        private void btnStäng_Click(object sender, EventArgs e)
        {
            Close();
        }
    

    private void HanteraKurserForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
