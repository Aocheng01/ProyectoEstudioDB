using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioDB.dao;
using EstudioDB.dto;
using Guna.UI2.WinForms;


namespace EstudioDB.Forms.FormsTimer
{
    public partial class FrmAñadirTarea : Form
    {
        public event EventHandler ProyectoAgregado;

        public FrmAñadirTarea()
        {
            InitializeComponent();
        }

        public void cargarListaProyectos()
        {
            DaoProyecto daoProyecto = new DaoProyecto();
            List<Proyecto> listaProyectos = daoProyecto.obtenerProyecto();

            ProyectoAgregado?.Invoke(this, EventArgs.Empty);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Proyecto proyecto = new Proyecto(gunaTxtNombreProyecto.Text);

            DaoProyecto daoProyecto = new DaoProyecto();
            daoProyecto.insertarProyecto(proyecto);

            cargarListaProyectos();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
