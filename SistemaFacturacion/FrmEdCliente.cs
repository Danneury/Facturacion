using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class FrmEdCliente : Form
    {
        ErrorProvider errorP = new ErrorProvider();
        public SqlConnection con { get; set; }
        public string Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Rnc_Cedula { get; set; }
        public string Estado { get; set; }
        public string modo { get; set; }

        public FrmEdCliente()
        {
            InitializeComponent();
        }

        private void FrmEdCliente_Load(object sender, EventArgs e)
        {
            try
            {
                if (!modo.Equals("C"))
                    txtIdCliente.Text = Id_Cliente;
                txtNombre.Text = Nombre;
                txtRnc_Cedula.Text = Rnc_Cedula;
                txtEstado.Text = Estado;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar valores");
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete Clientes ";
                sql += " where Id_Cliente = '" + txtIdCliente.Text + "'";
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

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEstado.Text)
                || string.IsNullOrEmpty(txtRnc_Cedula.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            else
            {

                if (validaCedula(txtRnc_Cedula.Text) || esUnRNCValido(txtRnc_Cedula.Text))
                {
                    try
                    {
                        string sql = "";
                        if (modo.Equals("C"))
                        {
                            sql = "insert into Clientes (Nombre, Rnc_Cedula, Estado) Values ('";
                            sql += txtNombre.Text + "', '";
                            sql += txtRnc_Cedula.Text + "','" + txtEstado.Text + "')";
                        }
                        else
                        {
                            sql = "update Clientes set ";
                            sql += "Nombre = '" + txtNombre.Text + "',";
                            sql += "Rnc_Cedula = '" + txtRnc_Cedula.Text + "',";
                            sql += "Estado= '" + txtEstado.Text + "'";
                            sql += " where Id_Cliente = '" + txtIdCliente.Text + "'";
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
                else
                {

                    MessageBox.Show("Cedula o rnc Incorrectos");
                }
            }
        }

        public static bool validaCedula(String pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private bool esUnRNCValido(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

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

        private void txtRnc_Cedula_Leave(object sender, EventArgs e)
        {
            if (Validartxt.textosvacios(txtRnc_Cedula))
            {
                errorP.SetError(txtRnc_Cedula, "No se puede dejar vacio");
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
