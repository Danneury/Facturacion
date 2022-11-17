using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void gestiónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiónDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            FrmMantArticulos frm = new FrmMantArticulos();
            frm.Show();
        }

        private void gestiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmMantCondicionesDePago frm = new FrmMantCondicionesDePago();
            frm.Show();
        }
    }
}
