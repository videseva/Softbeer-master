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
using BLL;

namespace PresentacionGUI
{
    public partial class FrmCliente : Form
    {
        ClienteService clienteService;
        Cliente cliente;
        List<Cliente> clientes;
        string cedula;

        public FrmCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService();
            //Consultar();
            BtnEditarCliente.Enabled = false;
            BtnEliminarCliente.Enabled = false;
        }


        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            RefreshBox();
        }

        private void RefreshBox()
        {
            TxtNumeroIdentificacion.Text = "";
            TxtPrimerNombreCliente.Text = "";
            TxtSegundoNombreCliente.Text = "";
            TxtPrimerApellidoCliente.Text = "";
            TxtSegundoApellidoCliente.Text = "";
            TxtDireccion.Text = "";
            TxtCorreo.Text = "";
            TxtTelefono.Text = "";
            CbxGenero.Text = "";
        }

        public void Consultar()
        {
            DtgClientes.Rows.Clear();

            clientes = clienteService.Consultar();

            foreach (var item in clientes)
            {
                DtgClientes.Rows.Add(item.Identificacion, item.PrimerNombre, item.SegundoNombre, item.PrimerApellido, item.SegundoApellido, item.Telefono, item.Correo, item.Direccion, item.Genero);
            }
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroIdentificacion.Text))
            {
                MessageBox.Show("DEBES COMPLETAR LA INFORMACION");

            }
            else
            {
                var op = MessageBox.Show("DESEA GUARDAR ESTE CLIENTE", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (op == DialogResult.Yes)
                {

                    Cliente cliente = new Cliente();

                    MapearCliente(cliente);
                    string message = clienteService.Guardar(cliente);
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

        private void MapearCliente(Cliente cliente)
        {
            cliente.Identificacion = TxtNumeroIdentificacion.Text;
            cliente.PrimerNombre = TxtPrimerNombreCliente.Text;

            if (string.IsNullOrEmpty(TxtSegundoNombreCliente.Text))
            {
                cliente.SegundoNombre = " ";
            }
            else
            {
                cliente.SegundoNombre = TxtSegundoNombreCliente.Text;

            }
            cliente.PrimerApellido = TxtPrimerApellidoCliente.Text;
            if (string.IsNullOrEmpty(TxtSegundoApellidoCliente.Text))
            {
                cliente.SegundoApellido = " ";
            }
            else
            {
                cliente.SegundoApellido = TxtSegundoApellidoCliente.Text;

            }
           
            cliente.Telefono = TxtTelefono.Text;
            cliente.Correo = TxtCorreo.Text;
            if (string.IsNullOrEmpty(TxtDireccion.Text))
            {
                cliente.Direccion =" ";
            }
            else
            {
                cliente.Direccion = TxtDireccion.Text;

            }

       
            cliente.Genero = CbxGenero.Text;
        }

        

        private Cliente GetClienteSelect()
        {
            Cliente cliente = new Cliente();
            var filaSeleccionada = DtgClientes.CurrentRow;

            cliente.Identificacion = filaSeleccionada.Cells[0].Value.ToString();
            cliente.PrimerNombre = filaSeleccionada.Cells[1].Value.ToString();
            cliente.SegundoNombre = filaSeleccionada.Cells[2].Value.ToString();
            cliente.PrimerApellido = filaSeleccionada.Cells[3].Value.ToString();
            cliente.SegundoApellido = filaSeleccionada.Cells[4].Value.ToString();
            cliente.Telefono = filaSeleccionada.Cells[5].Value.ToString();
            cliente.Correo = filaSeleccionada.Cells[6].Value.ToString();
            cliente.Direccion = filaSeleccionada.Cells[7].Value.ToString();
            cliente.Genero = filaSeleccionada.Cells[8].Value.ToString();
            return cliente;
        }



        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("Desea eliminar este cliente", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                MapearCliente(cliente);
                string mensaje = clienteService.Eliminar(cliente.Identificacion);
                MessageBox.Show(mensaje, "Cliente" + cliente.Identificacion + "eliminado con exito");
                Consultar();
                BtnRegistrarCliente.Enabled = true;
                BtnLimpiarCampos.Enabled = true;
                RefreshBox();
            }

        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("DESEA MODIFICAR ESTE CLIENTE", "EDITAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();
                MapearCliente(cliente);
                string mensaje = clienteService.Editar(cliente);
                MessageBox.Show(mensaje, "Cliente"+cliente.Identificacion+"modificado con exito");
                Consultar();
                BtnRegistrarCliente.Enabled = true;
                BtnLimpiarCampos.Enabled = true;
                RefreshBox();
            }
        }


        private void DtgClientes_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DtgClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.DtgClientes.Rows[e.RowIndex];

                BtnEditarCliente.Enabled = true;
                BtnEliminarCliente.Enabled = true;
                TxtNumeroIdentificacion.Text = row.Cells["Column1"].Value.ToString();
                TxtPrimerNombreCliente.Text = row.Cells["Column2"].Value.ToString();
                TxtSegundoNombreCliente.Text = row.Cells["Column5"].Value.ToString();
                TxtPrimerApellidoCliente.Text = row.Cells["Column6"].Value.ToString();
                TxtSegundoApellidoCliente.Text = row.Cells["Column7"].Value.ToString();
                TxtTelefono.Text = row.Cells["Column4"].Value.ToString();
                TxtCorreo.Text = row.Cells["Column3"].Value.ToString();
                TxtDireccion.Text = row.Cells["Column8"].Value.ToString();
                CbxGenero.Text = row.Cells["Column9"].Value.ToString();
                BtnRegistrarCliente.Enabled = false;
                BtnLimpiarCampos.Enabled = false;

            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String identificacion;
            identificacion = TxtNumeroIdentificacion.Text;
            cliente = clienteService.Filtrar(identificacion);
            DtgClientes.Rows.Clear();
            var filaSeleccionada = DtgClientes;

          
        }
    }
}
