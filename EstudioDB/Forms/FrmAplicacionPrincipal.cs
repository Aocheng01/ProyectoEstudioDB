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

namespace EstudioDB.Forms
{
    public partial class FrmAplicacionPrincipal : Form
    {
        public FrmAplicacionPrincipal()
        {
            InitializeComponent();
            guna2BorderlessForm1 = new Guna2BorderlessForm();
            guna2BorderlessForm1.ContainerControl = this;

            // Llama a la función para redondear solo tres esquinas en el evento Load
            this.Load += FrmAplicacionPrincipal_Load;
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.guna2PanelAplicaiones.Controls.Count > 0)
                this.guna2PanelAplicaiones.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.guna2PanelAplicaiones.Controls.Add(fh);
            this.guna2PanelAplicaiones.Tag = fh;
            fh.Size = this.guna2PanelAplicaiones.Size; // Ajuste manual del tamaño
            fh.Show();
        }
        private void FrmAplicacionPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmTimer());

            int radius = 70; // Ajusta el radio de las esquinas redondeadas
            GraphicsPath path = new GraphicsPath();

            // Define las esquinas a redondear (dos superiores y una inferior izquierda)
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90); // Esquina superior derecha
            path.AddLine(this.Width, radius, this.Width, this.Height); // Lado derecho
            path.AddLine(this.Width, this.Height, radius, this.Height); // Lado inferior
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);

        }

        private void panelContenedorTodo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de cerrar la aplicación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2PanelTitulo2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImgBtnMin_Click(object sender, EventArgs e)
        {
            FrmLogin formularioLogin = new FrmLogin();
            this.WindowState=FormWindowState.Minimized;
            formularioLogin.WindowState=FormWindowState.Minimized;
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImgBtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de cerrar la aplicación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2PanelAplicaiones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
