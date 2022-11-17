using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FrmEdArticulo : Form
    {
        ErrorProvider errorP = new ErrorProvider();
        public SqlConnection con { get; set; }
        public string Id_Articulo { get; set; }
        public string Articulo { get; set; }
        public string Costo_Unitario { get; set; }
        public string Precio_Unitario { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }
        public FrmEdArticulo()
        {
            InitializeComponent();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtArticulo.Text) || string.IsNullOrEmpty(txtEstado.Text)
                || string.IsNullOrEmpty(txtCostoUnitario.Text) || string.IsNullOrEmpty(txtPrecioUnitario.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else if (int.Parse(txtCostoUnitario.Text) > int.Parse(txtPrecioUnitario.Text))
            {
                MessageBox.Show("El costo no puede ser mayor al precio");
                return;
            }
            else
            {
                try
                {
                    string sql = "";
                    if (modo.Equals("C"))
                    {
                        sql = "insert into Articulos (Articulo, Costo_unitario, Precio_Unitario, Estado) Values ('";
                        sql += txtArticulo.Text + "','" + txtCostoUnitario.Text + "','";
                        sql += txtPrecioUnitario.Text + "','" + txtEstado.Text + "')";
                    }
                    else
                    {
                        sql = "update Articulos set ";
                        sql += "Articulo = '" + txtArticulo.Text + "',";
                        sql += "Costo_Unitario = '" + txtPrecioUnitario.Text + "',";
                        sql += "Precio_Unitario= '" + txtCostoUnitario.Text + "',";
                        sql += "Estado= '" + txtEstado.Text + "'";
                        sql += " where Id_Articulo = '" + txtIdArticulo.Text + "'";
                    }
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado con exito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Articulos ";
                sql += " where Id_Articulo = '" + txtIdArticulo.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado con exito");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el registro");
            }

        }

        private void FrmEdArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                if (!modo.Equals("C"))
                    txtIdArticulo.Text = Id_Articulo;
                txtArticulo.Text = Articulo;
                txtCostoUnitario.Text = Costo_Unitario;
                txtPrecioUnitario.Text = Precio_Unitario;
                txtEstado.Text = Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }


        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validartxt.solonumeros(e);
            if (!valida)
            {
                errorP.SetError(txtCostoUnitario, "Solo Numeros");
            }
            else
            {
                errorP.Clear();
            }

        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validartxt.solonumeros(e);
            if (!valida)
            {
                errorP.SetError(txtPrecioUnitario, "Solo Numeros");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtArticulo_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtArticulo))
            {
                errorP.SetError(txtArticulo, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtPrecioUnitario))
            {
                errorP.SetError(txtPrecioUnitario, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtCostoUnitario_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtCostoUnitario))
            {
                errorP.SetError(txtCostoUnitario, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtEstado_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosNulos(txtEstado))
            {
                errorP.SetError(txtEstado, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        
    }
}
