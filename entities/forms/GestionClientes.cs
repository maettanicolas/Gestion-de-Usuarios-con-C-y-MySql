using GestionUsuarios.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ClienteDao baseDeDatos = new ClienteDao();
            baseDeDatos.Guardar(cliente);
            actualizarLista();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int indice = listClientes.SelectedIndex;
                listClientes.Items.RemoveAt(indice);
            }
            catch (Exception)
            {
                MessageBox.Show("No hay ningun dato para eliminar");
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
