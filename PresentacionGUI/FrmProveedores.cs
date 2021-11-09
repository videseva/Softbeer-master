using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Entity;
using BLL;
using System.Windows.Forms;


namespace PresentacionGUI
{
    public partial class FrmProveedores : Form
    {
        ProveedorServices proveedorServices;
        Proveedor proveedor;
       List<Proveedor> proveedores;
        public FrmProveedores()
        {
            InitializeComponent();
            proveedorServices = new ProveedorServices();
            //Consultar();
            BtnEliminar.Enabled = false;
            btEditar.Enabled = false;
        }


        public void Consultar()
        {
            DtgProveedor.Rows.Clear();

            proveedores = proveedorServices.Consultar();

            foreach (var item in proveedores)
            {
                DtgProveedor.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Telefono, item.Genero, item.Correo, item.NitEmpresa, item.NombreEmpresa);
            }
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            RefreshBox();
        }
        private void BtnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroIdentificacion.Text))
            {
                MessageBox.Show("DEBES COMPLETAR LA INFORMACION");

            }else { 

                var op = MessageBox.Show("DESEA GUARDAR ESTE CLIENTE", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (op == DialogResult.Yes)
                {
                    Proveedor proveedor = new Proveedor();

                    MapearProveedor(proveedor);
                    string message;
                    message = proveedorServices.Guardar(proveedor);
                    CuadrosDialogo.BoxInfo(message, this);
                    RefreshBox();
                    Consultar();
                }
                else
                {
                    RefreshBox();
                }

                }


        }
        private Proveedor GetProveedorSelect()
        {
            Proveedor proveedor = new Proveedor();
            var filaSeleccionada = DtgProveedor.CurrentRow;

            proveedor.Identificacion = filaSeleccionada.Cells[0].Value.ToString();
            proveedor.PrimerNombre = filaSeleccionada.Cells[1].Value.ToString();
            proveedor.SegundoNombre = filaSeleccionada.Cells[2].Value.ToString();
            proveedor.PrimerApellido = filaSeleccionada.Cells[3].Value.ToString();
            proveedor.SegundoApellido = filaSeleccionada.Cells[4].Value.ToString();
            proveedor.Telefono = filaSeleccionada.Cells[5].Value.ToString();
            proveedor.Genero = filaSeleccionada.Cells[6].Value.ToString();
            proveedor.Correo = filaSeleccionada.Cells[7].Value.ToString();
            proveedor.NitEmpresa = filaSeleccionada.Cells[8].Value.ToString();
            proveedor.NombreEmpresa = filaSeleccionada.Cells[9].Value.ToString();

            return proveedor;
        }
        private void MapearProveedor(Proveedor proveedor)
        {
            proveedor.Identificacion = TxtNumeroIdentificacion.Text;
            proveedor.PrimerNombre = TxtPrimerNombre.Text;
            if (string.IsNullOrEmpty(TxtSegundoNombre.Text))
            {
                proveedor.SegundoNombre =" ";
            }
            else
            {
                proveedor.SegundoNombre = TxtSegundoNombre.Text;

            }
            
            proveedor.PrimerApellido = TxtPrimerApellido.Text;
            if (string.IsNullOrEmpty(TxtSegundoNombre.Text))
            {
                proveedor.SegundoApellido =" ";
            }
            else
            {
                proveedor.SegundoApellido = TxtSegundoApellido.Text;

            }
         
            proveedor.Telefono = TxtTelefono.Text;
            proveedor.Correo = TxtCorreo.Text;
            proveedor.NitEmpresa = TxtNitEmpresa.Text;
            proveedor.NombreEmpresa = TxtNombreEmpresa.Text;
            proveedor.Genero = MapGenero(CmbGenero.Text);

        }
        private string  MapGenero(string sexo)
        {
            if (sexo.Equals("Masculino"))
                return "Masculino";
            else
                return "Femenino";
        }
        private void RefreshBox()
        {
            TxtNumeroIdentificacion.Text = "";
            TxtPrimerNombre.Text = "";
            TxtSegundoNombre.Text = "";
            TxtPrimerNombre.Text = "";
            TxtPrimerApellido.Text = "";
            TxtSegundoApellido.Text = "";
            TxtCorreo.Text = "";
            TxtNitEmpresa.Text = "";
            TxtNombreEmpresa.Text = "";
            TxtTelefono.Text = "";
            CmbGenero.Text = "";
        }

        private void BtnProbarConexion_Click(object sender, EventArgs e)
        {
            OracleConnection oracleConnection;
            oracleConnection = new OracleConnection("DATA SOURCE = localhost:1521/xepdb1; USER ID = AdminSoftbeer  ; PASSWORD=12345");

            try
            {
                oracleConnection.Open();
                MessageBox.Show("conetado"+ oracleConnection.DataSource+"     a la base de datos : "+oracleConnection.Database);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DtgProveedor_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DtgProveedor_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgProveedor.SelectedRows.Count> 0)
            {
                DataGridViewRow row = this.DtgProveedor.Rows[e.RowIndex];
                BtnEliminar.Enabled = true;
                btEditar.Enabled = true;
                TxtNumeroIdentificacion.Text = row.Cells["ClmIdentificacion"].Value.ToString();
                TxtPrimerNombre.Text = row.Cells["ClmNombre1"].Value.ToString();
                TxtSegundoNombre.Text = row.Cells["ClmNombre2"].Value.ToString();
                TxtPrimerApellido.Text = row.Cells["ClmApellido1"].Value.ToString();
                TxtSegundoApellido.Text = row.Cells["ClmApellido2"].Value.ToString();
                TxtCorreo.Text = row.Cells["ClmCorreo"].Value.ToString();
                TxtTelefono.Text = row.Cells["ClmTelefono"].Value.ToString();
                TxtNitEmpresa.Text = row.Cells["ClmNitEmpresa"].Value.ToString();
                TxtNombreEmpresa.Text = row.Cells["ClmNombreEmpresa"].Value.ToString();
                CmbGenero.Text = row.Cells["ClmGenero"].Value.ToString();
                BtnRegistrarProveedor.Enabled = false;
                BtnLimpiarCampos.Enabled = false;
                BtnLimpiarCampos.Enabled = true;
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("DESEA MODIFICAR ESTE PROVEEDOR", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {
                Proveedor proveedor = new Proveedor();
                MapearProveedor(proveedor);
                string mensaje = proveedorServices.Editar(proveedor);
                MessageBox.Show(mensaje, "PROVEEDOR " + proveedor.Identificacion + "modificado con exito");
                Consultar();
               
                RefreshBox();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("Desea eliminar este cliente", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {
                Proveedor proveedor = new Proveedor();
                MapearProveedor(proveedor);
                string mensaje = proveedorServices.Eliminar(proveedor.Identificacion);
                MessageBox.Show(mensaje, "Proveedor " + proveedor.Identificacion + "eliminado con exito");
                Consultar();
                BtnRegistrarProveedor.Enabled = true;
                BtnLimpiarCampos.Enabled = true;
                RefreshBox();
            }
        }
    }
}
