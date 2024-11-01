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
    internal class DaoProyecto
    {
        public void insertarProyecto(Proyecto proyecto)
        {
            try
            {
                string query = "INSERT INTO proyecto (nombreProyecto) VALUES (@nombreProyecto)";

                Conexion objetoConexion = new Conexion();

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@nombreProyecto", proyecto.NombreProyecto);

                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Proyecto registrada correctamente.");
                while (reader.Read())
                {
                    objetoConexion.cerrarConexion();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Código de error para duplicados
                {
                    MessageBox.Show("Ya existe una tarea con ese nombre. Por favor, elige otro nombre.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al agregar la tarea: " + ex.Message);
                }

            }

        }

        public List<Proyecto> obtenerProyecto()
        {
            List<Proyecto> listaProyecto = new List<Proyecto>();
            try
            {
                string query = "SELECT * FROM proyecto";

                Conexion objetoConexion = new Conexion();

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    Proyecto proyecto = new Proyecto(
                        reader.GetInt16(0),
                        reader.GetString(1)
                    );
                    listaProyecto.Add(proyecto);
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la lista de proyectos." + ex.ToString());
            }

            return listaProyecto;
        }

        public void actualizarProyectos(Proyecto proyecto)
        {
            try
            {
                string query =
                    "UPDATE proyecto SET nombreProyecto=@nombreProyecto WHERE idProyecto=@idProyecto";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@nombreProyecto", proyecto.NombreProyecto);
                myCommand.Parameters.AddWithValue("@idProyecto", proyecto.ProyectoId);


                objetoConexion.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la proyecto." + ex.ToString());
            }
        }

        public void eliminarProyecto(int id)
        {
            try
            {
                string query = "DELETE FROM proyecto WHERE proyectoID=@proyectoID";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@proyectoID", id);

                myCommand.ExecuteNonQuery();
                objetoConexion.cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la proyecto." + ex.ToString());
            }
        }
    }
}


