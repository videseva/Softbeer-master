using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public static class CuadrosDialogo
    {
        public static void BoxInfo(string texto, Form frm)
        {
            var nombreFormulario = frm.Text;
            MessageBox.Show(texto, nombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void BoxSolicitud(string texto, Form frm)
        {
            var nombreFormulario = frm.Text;
            MessageBox.Show(texto, nombreFormulario, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
