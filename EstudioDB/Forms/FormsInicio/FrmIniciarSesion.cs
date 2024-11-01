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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            iniciarSesion?.Invoke(this,EventArgs.Empty);
            this.Close();
        }
    }
}
