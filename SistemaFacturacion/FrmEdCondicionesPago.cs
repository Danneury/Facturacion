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
    public partial class FrmEdCondicionesPago : Form
    {
        ErrorProvider errorP = new ErrorProvider();
        public SqlConnection con { get; set; }
        public string Id_Pago { get; set; }
        public string Descripcion { get; set; }
        public string Cantidad_De_Dias { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }
        public FrmEdCondicionesPago()
        {
            InitializeComponent();
        }

        private void FrmEdCondicionesPago_Load(object sender, EventArgs e)
        {
            try
            {
                if (!modo.Equals("C"))
                txtId_Pago.Text = Id_Pago;
                txtDescripcion.Text = Descripcion;
                txtCantidad_De_Dias.Text = Cantidad_De_Dias;
                txtEstado.Text = Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text) && string.IsNullOrEmpty(txtEstado.Text) 
                && string.IsNullOrEmpty(txtCantidad_De_Dias.Text))
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
                        sql = "insert into Condiciones_Pago (Descripcion, Cantidad_De_Dias, Estado) Values ('";
                        sql += txtDescripcion.Text + "', '";
                        sql += txtCantidad_De_Dias.Text + "','" + txtEstado.Text + "')";
                    }
                    else
                    {
                        sql = "update Condiciones_Pago set ";
                        sql += "Descripcion = '" + txtDescripcion.Text + "',";
                        sql += "Cantidad_De_Dias = '" + txtCantidad_De_Dias.Text + "',";
                        sql += "Estado = '" + txtEstado.Text + "'";
                        sql += " where Id_Pago = '" + txtId_Pago.Text + "'";
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
                string sql = "delete Condiciones_Pago ";
                sql += " where Id_Pago = '" + txtId_Pago.Text + "'";
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

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtDescripcion))
            {
                errorP.SetError(txtDescripcion, "No se puede dejar vacio");
            }
            else
            {
                errorP.Clear();
            }
        }

        private void txtCantidad_De_Dias_Leave(object sender, EventArgs e)
        {
            if(Validartxt.textosvacios(txtCantidad_De_Dias))
            {
                errorP.SetError(txtCantidad_De_Dias, "No se puede dejar vacio");
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

        private void txtCantidad_De_Dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validartxt.solonumeros(e);
            if (!valida)
            {
                errorP.SetError(txtCantidad_De_Dias, "Solo Numeros");
            }
            else
            {
                errorP.Clear();
            }
        }
    }
}
