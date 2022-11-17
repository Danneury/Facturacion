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
    public partial class FrmEdVendedores : Form
    {
        ErrorProvider errorP = new ErrorProvider();
        public SqlConnection con { get; set; }
        public string Id_Vendedor { get; set; }
        public string Nombre { get; set; }
        public string Porciento_Comision { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }
        public FrmEdVendedores()
        {
            InitializeComponent();
        }

        private void FrmEdVendedores_Load(object sender, EventArgs e)
        {
            try
            {
                if (!modo.Equals("C"))
                txtId_Vendedor.Text = Id_Vendedor;
                txtNombre.Text = Nombre;
                txtPorciento_Comision.Text = Porciento_Comision;
                txtEstado.Text = Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEstado.Text) 
                || string.IsNullOrEmpty(txtPorciento_Comision.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {
                try
                {
                    string sql = "";
                    if (modo.Equals("C"))
                    {
                        sql = "insert into Vendedores (Nombre, Porciento_Comision, Estado) Values ('";
                        sql += txtNombre.Text + "', '";
                        sql += txtPorciento_Comision.Text + "','" + txtEstado.Text + "')";
                    }
                    else
                    {
                        sql = "update Vendedores set ";
                        sql += "Nombre = '" + txtNombre.Text + "',";
                        sql += "Porciento_Comisión = '" + txtPorciento_Comision.Text + "',";
                        sql += "Estado = '" + txtEstado.Text + "'";
                        sql += " where Id_Vendedor = '" + txtId_Vendedor.Text + "'";
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
                string sql = "delete Vendedores ";
                sql += " where Id_Vendedor = '" + txtId_Vendedor.Text + "'";
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

        private void txtPorciento_Comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validartxt.solonumeros(e);
            if (!valida)
            {
                errorP.SetError(txtPorciento_Comision, "Solo Numeros");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtNombre))
            {
                errorP.SetError(txtNombre, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtPorciento_Comision_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtPorciento_Comision))
            {
                errorP.SetError(txtPorciento_Comision, "No se puede dejar vacio");
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
