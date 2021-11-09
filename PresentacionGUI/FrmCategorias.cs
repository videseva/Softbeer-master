using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmCategorias : Form
    {
        CategoriaServices categoriaService;
        Categoria categoria;
        List<Categoria> categorias;
        string mensaje = "";

        public FrmCategorias()
        {
            InitializeComponent();
            categoriaService = new CategoriaServices();
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = "";
        }

        private void btnguardarCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Debe completar la informacion");
            }
            else
            {
                categoria = new Categoria();
                categoria.Nombre = TxtNombre.Text;
                string message;
                message = categoriaService.Guardar(categoria);
                CuadrosDialogo.BoxInfo(message, this);

            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
