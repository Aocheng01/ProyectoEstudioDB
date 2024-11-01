using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void FrmAplicacionPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
