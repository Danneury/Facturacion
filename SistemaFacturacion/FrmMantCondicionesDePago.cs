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
    public partial class FrmMantCondicionesDePago : Form
    {
        SqlConnection con = null;
        public FrmMantCondicionesDePago()
        {
            InitializeComponent();
        }

        private void FrmMantCondicionesDePago_Load(object sender, EventArgs e)
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

        private void EjecutarConsulta()
        {
            try
            {
                string sql = " Select * From Condiciones_Pago ";
                sql += "Where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvArticulo.DataSource = dt;
                DgvArticulo.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar. " + ex.Message);
            }
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCondicionesPago frm = new FrmEdCondicionesPago();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void DgvArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvArticulo.SelectedRows[0];
                FrmEdCondicionesPago frm = new FrmEdCondicionesPago();
                frm.Id_Pago = row.Cells[0].Value.ToString();
                frm.Descripcion = row.Cells[1].Value.ToString();
                frm.Cantidad_De_Dias = row.Cells[2].Value.ToString();
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

        private void FrmMantCondicionesDePago_Activated(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }
    }
}
