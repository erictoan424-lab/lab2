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

namespace Lab2GIU
{
    public partial class Form1 : Form
    {
        private StudentRegister studentRegister = new StudentRegister();
        private List<Administratör> administratör = new List<Administratör>();
        private InloggningsService inloggningsService;

        public Form1()
        {
            InitializeComponent();
            inloggningsService = new InloggningsService(studentRegister, administratör);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string epost = txtEpost.Text;
            string lösenord = txtLosenord.Text;

            bool lyckades = inloggningsService.LoggaIn(epost, lösenord);

            if (lyckades)
            {
                MessageBox.Show("Din inloggning lyckades");
            }
            else
            {
                MessageBox.Show("Fel e-post eller lösenord!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
