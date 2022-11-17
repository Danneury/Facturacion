using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FrmMantVendedores : Form
    {
        SqlConnection con = null;
        public FrmMantVendedores()
        {
            InitializeComponent();
        }

        private void FrmMantVendedores_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-T66GIJO;Initial Catalog=SFBD;Integrated Security=True");
                con.Open();
                CbxCriterio.SelectedIndex = 0;
                EjecutarConsulta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos" + ex);
            }
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdVendedores frm = new FrmEdVendedores();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void EjecutarConsulta()
        {
            try
            {
                string sql = " Select * From Vendedores ";
                sql += "Where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvVendedores.DataSource = dt;
                DgvVendedores.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar. " + ex.Message);
            }
        }

        private void DgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvVendedores.SelectedRows[0];
                FrmEdVendedores frm = new FrmEdVendedores();
                frm.Id_Vendedor = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Porciento_Comision = row.Cells[2].Value.ToString();
                frm.Estado = row.Cells[3].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
        }

        private void FrmMantVendedores_Activated(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }
    }
}
