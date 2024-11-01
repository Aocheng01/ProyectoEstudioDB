using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioDB.dao;
using EstudioDB.dto;
using EstudioDB.Forms.FormsTimer;

namespace EstudioDB.Forms
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();

            cargarListaProyectos();


            //Para el borde//
            guna2BorderlessForm1 = new Guna2BorderlessForm();
            guna2BorderlessForm1.ContainerControl = this;

            this.Load += FrmTimer_Load;
            //Para el borde//
        }

        public void cargarListaProyectos()
        {
            DaoProyecto daoProyecto = new DaoProyecto();
            List<Proyecto> listaProyectos = daoProyecto.obtenerProyecto();

            guna2DataGridView1.DataSource = listaProyectos;
            guna2DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {



            //Para el borde//
            int radius = 70; 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90); // Esquina superior derecha
            path.AddLine(this.Width, radius, this.Width, this.Height); // Lado derecho
            path.AddLine(this.Width, this.Height, radius, this.Height); // Lado inferior
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
            //Para el borde//
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FrmAñadirTarea añadirTarea = new FrmAñadirTarea();
            añadirTarea.ProyectoAgregado += AñadirTarea_ProyectoAgregado;
            añadirTarea.ShowDialog();

            
        }
        private void AñadirTarea_ProyectoAgregado(object sender, EventArgs e)
        {
            cargarListaProyectos();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                string id = row.Cells["ID"].Value.ToString();
                string name = row.Cells["Name"].Value.ToString();

                MessageBox.Show($"ID: {id}, Name: {name}");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                int idProyecto = Convert.ToInt16(guna2DataGridView1.SelectedRows[0].Cells["ProyectoId"].Value);


                DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este proyecto?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    DaoProyecto daoProyecto = new DaoProyecto();
                    daoProyecto.eliminarProyecto(idProyecto);
                    cargarListaProyectos();
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.");
                }

            }
        }

    }
}
