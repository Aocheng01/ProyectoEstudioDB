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
    internal class DaoSesionEstudio
    {
        public void insertarSsesionEstudio(SesionesEstudio sesionesEstudio)
        {
            try
            {
                string query = "INSERT INTO sesionesEstudio (asignaturaID, usuarioID, duracion, fecha)" +
                               "VALUES (@asignaturaID, @usuarioID, @duracion, @fecha)";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@asignaturaID", sesionesEstudio.asignaturaID);
                myCommand.Parameters.AddWithValue("@usuarioID", sesionesEstudio.usuarioID);
                myCommand.Parameters.AddWithValue("@duracion", sesionesEstudio.duracion);
                myCommand.Parameters.AddWithValue("@fecha", sesionesEstudio.fecha);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión de estudio registrada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al insertar sesion de estudio" + e.ToString());
            }
        }

        public List<SesionesEstudio> obtenerSesionesEstudio()
        {
            List<SesionesEstudio> listaSesionesEstudio = new List<SesionesEstudio>();
            try
            {
                string query = "SELECT * FROM sesionesEstudio";
                Conexion objetoConexion = new Conexion();
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    SesionesEstudio sesionEstudio = new SesionesEstudio(
                        reader.GetInt16(0),
                        reader.GetInt16(1),
                        reader.GetInt16(2),
                        reader.GetInt16(3),
                        reader.GetDateTime(4)
                    );
                    listaSesionesEstudio.Add(sesionEstudio);
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al obtener lista de sesiones de estudio" + e.ToString());
            }

            return listaSesionesEstudio;
        }

        public void actualizarSesionEstudio(SesionesEstudio sesionesEstudio)
        {
            try
            {
                string query = "UPDATE sesionesEstudio set duracion = @duracion, fecha = @fecha WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@duracion", sesionesEstudio.duracion);
                myCommand.Parameters.AddWithValue("@fecha", sesionesEstudio.fecha);
                myCommand.Parameters.AddWithValue("@id", sesionesEstudio.sesionID);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión de estudio actualizada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al actualiar. " + e.ToString());
            }
        }

        public void eliminarSesionEstudio(int id, SesionesEstudio sesion)
        {
            try
            {
                string query = "DELETE FROM sesionesEstudio WHERE id = @id";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@id", id);
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Sesión de estudio eliminada correctamente.");
                objetoConexion.cerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar. " + e.ToString());
            }
        }
    }
}
