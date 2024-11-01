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

namespace EstudioDB.Forms
{
    public partial class FrmRegister : Form
    {
        public event EventHandler CerrarRegistro;
        public FrmRegister()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(200, 400);
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (gunaTxtContraseña.Text != gunaTxtRepetirContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DaoUsuario daoUsuario = new DaoUsuario();
                Usuario usuario = new Usuario(gunaTxtUsuario.Text,gunaTxtContraseña.Text);
                daoUsuario.insertarUsuario(usuario);

                CerrarRegistro?.Invoke(this, EventArgs.Empty);
                this.Close();


            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarRegistro?.Invoke(this, EventArgs.Empty);
            this.Close();

        }
    }
}
