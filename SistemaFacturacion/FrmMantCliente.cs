using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FrmMantCliente : Form
    {
        SqlConnection con = null;
        public FrmMantCliente()
        {
            InitializeComponent();
        }

        private void FrmMantCliente_Load(object sender, EventArgs e)
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
        private void TxtABuscar_TextChanged(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }

        private void EjecutarConsulta()
        {
            try
            {
                string sql = " Select * From Clientes ";
                sql += "Where " + CbxCriterio.Text + " like '%" + TxtABuscar.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DgvCliente.DataSource = dt;
                DgvCliente.Refresh();
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

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvCliente.SelectedRows[0];
                FrmEdCliente frm = new FrmEdCliente();
                frm.Id_Cliente = row.Cells[0].Value.ToString();
                frm.Nombre = row.Cells[1].Value.ToString();
                frm.Rnc_Cedula = row.Cells[2].Value.ToString();
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

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdCliente frm = new FrmEdCliente();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void FrmMantCliente_Activated(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }
    }
}
