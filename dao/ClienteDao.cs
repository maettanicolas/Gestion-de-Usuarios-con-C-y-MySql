using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionUsuarios.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "clientes";
            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; User Id=" + usuario + "; password=" + password + "";
        
            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            return conexionDb;
        }
        public List<Cliente> ObtenerlistadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            string consulta = "SELECT * FROM clientes";
            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = lectura.GetString("nombre");
                cliente.Apellido = lectura.GetString("apellido");
                cliente.Telefono = lectura.GetString("telefono");
                cliente.TarjetaDeCredito = lectura.GetString("tarjeta_de_credito");
                lista.Add(cliente);
            }

            return lista;
        }

        internal void Guardar(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
