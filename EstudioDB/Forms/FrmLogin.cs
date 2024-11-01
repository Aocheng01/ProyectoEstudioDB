using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioDB.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace EstudioDB
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedorLoginRegister.Controls.Count > 0)
                this.panelContenedorLoginRegister.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorLoginRegister.Controls.Add(fh);
            this.panelContenedorLoginRegister.Tag = fh;
            fh.Size = this.panelContenedorLoginRegister.Size; // Ajuste manual del tamaño
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
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



        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkedState = guna2ImageCheckBox1.Checked;
            if (checkedState)
            {
                gunaTxtContraseña.PasswordChar = '\0';
            }
            else
            {
                gunaTxtContraseña.PasswordChar = '*';
            }
            
        }
        private void AbrirFormEnPanelTodo(object formhija)
        {
            if (this.panelContenedorTodo.Controls.Count > 0)
                this.panelContenedorTodo.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorTodo.Controls.Add(fh);
            this.panelContenedorTodo.Tag = fh;
            fh.Size = this.panelContenedorTodo.Size; // Ajuste manual del tamaño
            fh.BringToFront();

            fh.Show();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmRegister());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanelTodo(new FrmAplicacionPrincipal());
        }

        private void gunaTxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
