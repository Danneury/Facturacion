using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    class Validartxt
    {
        public static bool solonumeros(KeyPressEventArgs e)
        {
            if(Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }

        public static bool textosvacios(TextBox ptxt)
        {
            if (ptxt.Text == String.Empty)
            {
                ptxt.Focus();
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool textosNulos(ComboBox ctxt)
        {
            if(ctxt.Text == String.Empty)
            {
                ctxt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
