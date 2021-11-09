using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGUI
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TxtArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            new FrmAgregarCliente().Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void CmbPrestar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPrestar.Text.Equals("Si"))
            {
                TxtUnidadesPrestadas.Enabled = true;
            }
            else
                TxtUnidadesPrestadas.Enabled = false;
        }
    }
}
