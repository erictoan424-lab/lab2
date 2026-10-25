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
    public partial class HanteraAnnonserForm : Form
    {
        private AnnonsRegister annonsRegister;
        public HanteraAnnonserForm(AnnonsRegister annonsRegister)
        {
            InitializeComponent();
            this.annonsRegister = annonsRegister;
        }
        

        private void VisaAnnonser()
        {
            dgvAnnonser.DataSource = null;
            dgvAnnonser.DataSource =
                annonsRegister.HämtaTillgängligaAnnonser()
                .Select(a => new
                {
                    a.Id,
                    a.Titel,
                    a.Pris,
                    a.Skick
                })
                .ToList();
        }

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Knappen fungerar!");

            if (dgvAnnonser.CurrentRow == null)
            {
                MessageBox.Show("Välj en annons först.");
                return;
            }

            int annonsId = Convert.ToInt32(
                dgvAnnonser.CurrentRow.Cells["Id"].Value);

            Annons annons = annonsRegister.HittaAnnons(annonsId);

            if (annons != null)
            {
                annonsRegister.TaBort(annons);
                VisaAnnonser();
                MessageBox.Show("Annonsen har tagits bort.");
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HanteraAnnonserForm_Load(object sender, EventArgs e)
        {
            VisaAnnonser();
        }

        private void dvgAnnonser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
