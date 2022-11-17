using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FrmMantArticulos : Form
    {
        SqlConnection con = null;
        public FrmMantArticulos()
        {
            InitializeComponent();
        }

        private void FrmMantArticulos_Load(object sender, EventArgs e)
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
                string sql = " Select * From Articulos ";
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

        private void TxtABuscar_TextChanged(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            EjecutarConsulta();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            FrmEdArticulo frm = new FrmEdArticulo();
            frm.con = con;
            frm.modo = "C";
            frm.ShowDialog();
        }

        private void DgvArticulo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvArticulo.SelectedRows[0];
                FrmEdArticulo frm = new FrmEdArticulo();
                frm.Id_Articulo = row.Cells[0].Value.ToString();
                frm.Articulo = row.Cells[1].Value.ToString();
                frm.Costo_Unitario = row.Cells[2].Value.ToString();
                frm.Precio_Unitario = row.Cells[3].Value.ToString();
                frm.Estado = row.Cells[4].Value.ToString();
                frm.modo = "U";
                frm.con = con;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar registro: " + ex.Message);
            }
        }
    }
}
