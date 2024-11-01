using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioDB.dao
{
    internal class Conexion
    {
        private MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string db = "EstudioDB";
        static string usuario = "root";
        static string password = "19933130000";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario
                                + "; password=" + password + "; database=" + db + ";";



        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se conectó a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos." + ex);

            }

            return conexion;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

    
    }
}
