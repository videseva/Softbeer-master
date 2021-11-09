using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace PresentacionGUI
{
    public partial class FrmEditarProveedor : Form
    {
        Proveedor proveedorParaEditar;
        public FrmEditarProveedor()
        {
            InitializeComponent();
        }
        public FrmEditarProveedor(Proveedor proveedorParaEditar)
        {
            InitializeComponent();
            this.proveedorParaEditar = proveedorParaEditar;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Proveedor proveedorNuevo = new Proveedor();
            proveedorNuevo.Identificacion = proveedorParaEditar.Identificacion;
            proveedorNuevo.PrimerNombre = TxtNombre1.Text;
            proveedorNuevo.SegundoNombre = TxtNombre2.Text;
            proveedorNuevo.PrimerApellido = TxtApellido1.Text;
            proveedorNuevo.SegundoNombre = TxtApellido2.Text;
            proveedorNuevo.Telefono = TxtTelefono.Text;
            proveedorNuevo.Correo = TxtCorreo.Text;
            proveedorNuevo.NitEmpresa = TxtNitEmpresa.Text;
            proveedorNuevo.NombreEmpresa = TxtEmpresa.Text;
            if (CmbGenero.Text.Equals("Masculino"))
                proveedorNuevo.Genero = "masculino";
            else
                proveedorNuevo.Genero = "femenno";

            //Llamar al metodo modificar, mandarle el proveedorParaEditar y proveedorNuevo()

            CuadrosDialogo.BoxInfo("Se ha modificado la informacion del proveedor", this);

        }
        private void CargarDatosProveedorOld()
        {
            TxtNombre1.Text = proveedorParaEditar.PrimerNombre;
            TxtNombre2.Text = proveedorParaEditar.SegundoNombre;
            TxtApellido1.Text = proveedorParaEditar.PrimerApellido;
            TxtApellido2.Text = proveedorParaEditar.SegundoApellido;
            CmbGenero.Text = proveedorParaEditar.Genero.ToString();
            TxtCorreo.Text = proveedorParaEditar.Correo;
            TxtTelefono.Text = proveedorParaEditar.Telefono;
            TxtNitEmpresa.Text = proveedorParaEditar.NitEmpresa;
            TxtEmpresa.Text = proveedorParaEditar.NombreEmpresa;
        }

        private void FrmEditarProveedor_Load(object sender, EventArgs e)
        {
            CargarDatosProveedorOld();
        }
    }
}
