using System;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMantArticulos frm = new FrmMantArticulos();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmMantCliente frm = new FrmMantCliente();
            frm.Show();
        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantCondicionesDePago frm = new FrmMantCondicionesDePago();
            frm.Show();
        }

        private void gestiónDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantVendedores frm = new FrmMantVendedores();
            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
