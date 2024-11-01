using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioDB.dto;
using MySql.Data.MySqlClient;

namespace EstudioDB.dao
{
    internal class DaoUsuario
    {
        public void insertarUsuario(Usuarios usuario)
        {
            try
            {
                string query = "INSERT INTO Usuarios (nombreUsuario, contraseña)" +
                               "VALUES (@nombreUsuario, @contraseña)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                mySqlCommand.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                MessageBox.Show("Usuario registrado correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar ususario" + e.ToString());
            }
        }

        public List<Usuarios> obtenerUsuarios()
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            try
            {
                string query = "SELECT * FROM Usuarios";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Usuarios usuario = new Usuarios(
                        reader.GetInt16(0),
                        reader.GetString(1),
                        reader.GetString(2)
                    );
                    listaUsuarios.Add(usuario);
                }
                reader.Close();
                objetoConexion.cerrarConexion();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al obtener lista de usuarios" + e.ToString());
            }

            return listaUsuarios;
        }

        public void actualizarUsuario(int id, Usuarios usuario)
        {
            try
            {
                string query =
                                "UPDATE usuarios set nombreUsuario = @nombreUsuario, contraseña = @contraseña where id = @id";
                            Conexion objetoConexion = new Conexion();
                            MySqlCommand myCommand= new MySqlCommand(query, objetoConexion.establecerConexion());
                            myCommand.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                            myCommand.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                            myCommand.Parameters.AddWithValue("@id", id);

                            MySqlDataReader reader = myCommand.ExecuteReader();
                            objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar usuario" + e.ToString());
            }
            
        }

        public void borrarUsuario(int id, Usuarios usuario)
        {
            try
            {
                string query = "DELETE FROM Usuarios WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Usuario borrado correctamente.");
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido borrar el usuario. " + e);
            }
        }
    }
}
