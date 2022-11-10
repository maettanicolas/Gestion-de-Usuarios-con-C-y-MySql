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
