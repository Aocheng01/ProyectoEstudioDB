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
    internal class DaoAsignatura
    {
        public void insertarAsignatura(Asignatura asignatura)
        {
            try
            {
                string query = "INSERT INTO asignaturas (nombreAsignatura) VALUES (@nombreAsignatura)";

                Conexion objetoConexion = new Conexion();

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@nombreAsignatura", asignatura.nombreAsignaura);

                MySqlDataReader reader = myCommand.ExecuteReader();
                MessageBox.Show("Asignatura registrada correctamente.");
                while (reader.Read())
                {
                    objetoConexion.cerrarConexion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la asignatura." + ex.ToString());

            }

        }

        public List<Asignatura> obtenerAsignaturas()
        {
            List<Asignatura> listaAsignaturas = new List<Asignatura>();
            try
            {
                string query = "SELECT * FROM asignaturas";

                Conexion objetoConexion = new Conexion();

                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());

                MySqlDataReader reader = myCommand.ExecuteReader();

                while (reader.Read())
                {
                    Asignatura asignatura = new Asignatura(
                        reader.GetInt16(0),
                        reader.GetString(1)
                    );
                    listaAsignaturas.Add(asignatura);
                }

                reader.Close();
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener la lista de asignaturas." + ex.ToString());
            }

            return listaAsignaturas;
        }

        public void actualizarAsignatura(Asignatura asignatura)
        {
            try
            {
                string query =
                    "UPDATE asignaturas SET nombreAsignatura=@nombreAsignatura WHERE idAsignatura=@idAsignatura";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@nombreAsignatura", asignatura.nombreAsignaura);
                myCommand.Parameters.AddWithValue("@idAsignatura", asignatura.asignaturaID);


                objetoConexion.cerrarConexion();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar la asignatura." + ex.ToString());
            }
        }

        public void eliminarAsignatura(int id, Asignatura asignatura)
        {
            try
            {
                string query = "DELETE FROM asignaturas WHERE idAsignatura=@idAsignatura";
                Conexion objetoConexion = new Conexion();
                MySqlCommand myCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                myCommand.Parameters.AddWithValue("@idAsignatura", id);

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la asignatura." + ex.ToString());
            }
        }
    }
}


