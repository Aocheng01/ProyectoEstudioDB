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
    internal class DaoSesion
    {
        public void insertarSesion(Sesion sesion)
        {
            try
            {
                string query = "INSERT INTO sesion (proyectoID, usuarioID, duracion, fecha)" +
                               "VALUES (@proyectoID, @usuarioID, @duracion, @fecha)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@proyectoID", sesion.asignaturaID);
                myCommand.Parameters.AddWithValue("@usuarioID", sesion.usuarioID);
                myCommand.Parameters.AddWithValue("@duracion", sesion.duracion);
                myCommand.Parameters.AddWithValue("@fecha", sesion.fecha);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión de sesion registrada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar sesion de sesion" + e.ToString());
            }
        }

        public List<Sesion> obtenerSesion()
        {
            List<Sesion> listaSesion = new List<Sesion>();
            try
            {
                string query = "SELECT * FROM sesion";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Sesion sesion = new Sesion(
                        reader.GetInt16(0),
                        reader.GetInt16(1),
                        reader.GetInt16(2),
                        reader.GetInt16(3),
                        reader.GetDateTime(4)
                    );
                    listaSesion.Add(sesion);
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al obtener lista de sesiones de sesion" + e.ToString());
            }

            return listaSesion;
        }

        public void actualizarSesion(Sesion sesion)
        {
            try
            {
                string query = "UPDATE sesion set duracion = @duracion, fecha = @fecha WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@duracion", sesion.duracion);
                myCommand.Parameters.AddWithValue("@fecha", sesion.fecha);
                myCommand.Parameters.AddWithValue("@id", sesion.sesionID);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión actualizada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualiar. " + e.ToString());
            }
        }

        public void eliminarSesion(int id, Sesion sesion)
        {
            try
            {
                string query = "DELETE FROM sesion WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión eliminada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar. " + e.ToString());
            }
        }
    }
}
