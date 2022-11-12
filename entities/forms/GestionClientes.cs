using GestionUsuarios.dao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionUsuarios
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            actualizarLista();
        }
        private void actualizarLista()
        {
            ClienteDao baseDeDatos = new ClienteDao();
            List<Cliente> listaDb = baseDeDatos.ObtenerlistadoDeClientes();
            listClientes.Items.Clear();
            for (int i = 0; i < listaDb.Count; i++)
            {
                Cliente cliente = listaDb[i];
                listClientes.Items.Add(cliente);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.TarjetaDeCredito = txtTarjetaDeCredito.Text;

            if (lblId.Text != "")
            {
                cliente.Id = lblId.Text;
            }

            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();
            limpiarListado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = (Cliente)listClientes.SelectedItem;
                ClienteDao baseDeDatos = new ClienteDao();
                baseDeDatos.Eliminar(cliente);
                actualizarLista();
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ningun dato para eliminar");
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)listClientes.SelectedItem;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono;
            txtTarjetaDeCredito.Text = cliente.TarjetaDeCredito;
            lblId.Text = cliente.Id;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            limpiarListado();


        }
        private void limpiarListado()
        {
            lblId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtTarjetaDeCredito.Text = "";
        }
    }
}
