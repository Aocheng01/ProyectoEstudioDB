﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;

namespace EstudioDB
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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
    }
}