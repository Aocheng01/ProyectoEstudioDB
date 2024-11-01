using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstudioDB.dto;
using MySql.Data.MySqlClient;

namespace EstudioDB.dao
{
    internal class DaoUsuario
    {
        public void insertarUsuario(Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return;
            }

            try
            {
                string query = "INSERT INTO usuario (nombreUsuario, contraseña) VALUES (@nombreUsuario, @contraseña)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                mySqlCommand.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                mySqlCommand.Parameters.AddWithValue("@contraseña", usuario.contraseña);

                mySqlCommand.ExecuteNonQuery();  // Cambiado a ExecuteNonQuery
                MessageBox.Show("Usuario registrado correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre. Por favor, elige otro nombre.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el usuario.");
                }
            }
        }

        public List<Usuario> obtenerUsuarios()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                string query = "SELECT * FROM usuario";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Usuario usuario = new Usuario(
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
                MessageBox.Show("Error al obtener lista de usuarios: " + e.ToString());
            }
            return listaUsuarios;
        }

        public void actualizarUsuario(int id, Usuario usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return;
            }

            try
            {
                string query = "UPDATE usuario SET nombreUsuario = @nombreUsuario, contraseña = @contraseña WHERE usuarioID = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                myCommand.Parameters.AddWithValue("@contraseña", usuario.contraseña);
                myCommand.Parameters.AddWithValue("@id", id);

                myCommand.ExecuteNonQuery();  // Cambiado a ExecuteNonQuery
                MessageBox.Show("Usuario actualizado correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualizar usuario: " + e.ToString());
            }
        }

        public void borrarUsuario(int id)
        {
            try
            {
                string query = "DELETE FROM usuario WHERE usuarioID = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.ExecuteNonQuery();  // Cambiado a ExecuteNonQuery
                MessageBox.Show("Usuario borrado correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido borrar el usuario: " + e.ToString());
            }
        }
    }
}
