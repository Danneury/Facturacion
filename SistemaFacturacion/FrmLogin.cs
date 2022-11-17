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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-T66GIJO;Initial Catalog=SFBD;Integrated Security=True");
        
        public void logear(string usuario, string contrasena)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Tipo_Usuario from Usuarios Where Usuario = @Usuario AND Contrasena = @Contrasena", con);
                cmd.Parameters.AddWithValue("Usuario", usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    
                    if (dt.Rows[0][0].ToString() == "Admin")
                    {
                        Menu frmMenu = new Menu();
                        this.Hide();
                        frmMenu.ShowDialog();
                    }
                    else if (dt.Rows[0][0].ToString() == "Normal")
                    {
                        Menu_Usuario frmMenu = new Menu_Usuario();
                        this.Hide();
                        frmMenu.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrectos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            con.Close();
        }
        private void CmdEntrar_Click(object sender, EventArgs e)
        {
            logear(this.txtUsuario.Text, this.txtContrasena.Text);


        }

    }
}
