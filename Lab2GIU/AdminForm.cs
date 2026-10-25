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
    public partial class AdminForm : Form
    {
        private AnnonsRegister annonsRegister;
        public AdminForm(AnnonsRegister annonsRegister)
        {
            InitializeComponent();
            this.annonsRegister = annonsRegister;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHanteraAnnonser_Click(object sender, EventArgs e)
        {
            HanteraAnnonserForm form =
       new HanteraAnnonserForm(annonsRegister);

            form.ShowDialog();
        }

        private void btnHanteraKurser_Click(object sender, EventArgs e)
        {
            HanteraKurserForm form = new HanteraKurserForm();
            form.ShowDialog();
        }
    }
}
