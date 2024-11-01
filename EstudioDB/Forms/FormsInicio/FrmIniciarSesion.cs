using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudioDB.dao;
using EstudioDB.dto;

namespace EstudioDB.Forms.FormsInicio
{
    public partial class FrmIniciarSesion : Form
    {
        public event EventHandler iniciarSesion;
        public FrmIniciarSesion()
        {
            InitializeComponent();
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            DaoUsuario daoUsuario = new DaoUsuario();
            List<Usuario> listaUsuarios = daoUsuario.obtenerUsuarios();

            String username = gunaTxtUsuario.Text;
            String password = gunaTxtContraseña.Text;

            // Buscar el usuario en la lista y si está, iniciar sesion, si no, usuario no existe o contraseña incorreta

            Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.nombreUsuario == username);
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("El usuario no existe.");
            }else if(usuarioEncontrado.contraseña!=password)

            {
                MessageBox.Show("Contraseña incorrecta.");
            }
            else
            {
                iniciarSesion?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
     


            
        }
    }
}
