using System;
using System.Windows.Forms;

namespace GestionUsuarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Gestionar_Click(object sender, EventArgs e)
        {
            GestionClientes ventanagestionClientes = new GestionClientes();
            ventanagestionClientes.ShowDialog();
        }
    }
}
