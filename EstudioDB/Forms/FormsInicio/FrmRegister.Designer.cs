﻿namespace EstudioDB.Forms
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.gunaTxtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaTxtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaTxtRepetirContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.lblRegistrar.Location = new System.Drawing.Point(189, 176);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(100, 30);
            this.lblRegistrar.TabIndex = 2;
            this.lblRegistrar.Text = "Registrar";
            // 
            // gunaTxtUsuario
            // 
            this.gunaTxtUsuario.Animated = true;
            this.gunaTxtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gunaTxtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(146)))));
            this.gunaTxtUsuario.BorderRadius = 8;
            this.gunaTxtUsuario.BorderThickness = 2;
            this.gunaTxtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtUsuario.DefaultText = "";
            this.gunaTxtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaTxtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtUsuario.Location = new System.Drawing.Point(76, 268);
            this.gunaTxtUsuario.Name = "gunaTxtUsuario";
            this.gunaTxtUsuario.PasswordChar = '\0';
            this.gunaTxtUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtUsuario.PlaceholderText = "Usuario";
            this.gunaTxtUsuario.SelectedText = "";
            this.gunaTxtUsuario.Size = new System.Drawing.Size(331, 52);
            this.gunaTxtUsuario.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(76, 477);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(181, 49);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Registrar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // gunaTxtContraseña
            // 
            this.gunaTxtContraseña.Animated = true;
            this.gunaTxtContraseña.BackColor = System.Drawing.Color.Transparent;
            this.gunaTxtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(146)))));
            this.gunaTxtContraseña.BorderRadius = 8;
            this.gunaTxtContraseña.BorderThickness = 2;
            this.gunaTxtContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtContraseña.DefaultText = "";
            this.gunaTxtContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaTxtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtContraseña.IconRightOffset = new System.Drawing.Point(8, 0);
            this.gunaTxtContraseña.Location = new System.Drawing.Point(76, 339);
            this.gunaTxtContraseña.Name = "gunaTxtContraseña";
            this.gunaTxtContraseña.PasswordChar = '*';
            this.gunaTxtContraseña.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtContraseña.PlaceholderText = "Contraseña";
            this.gunaTxtContraseña.SelectedText = "";
            this.gunaTxtContraseña.Size = new System.Drawing.Size(331, 50);
            this.gunaTxtContraseña.TabIndex = 6;
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageCheckBox1.CheckedState.Image = global::EstudioDB.Properties.Resources.visibility_24dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.guna2ImageCheckBox1.CheckedState.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageCheckBox1.Image = global::EstudioDB.Properties.Resources.visibility_24dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageCheckBox1.IndicateFocus = true;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(363, 348);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ImageCheckBox1.TabIndex = 8;
            this.guna2ImageCheckBox1.UseTransparentBackground = true;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // gunaTxtRepetirContraseña
            // 
            this.gunaTxtRepetirContraseña.Animated = true;
            this.gunaTxtRepetirContraseña.BackColor = System.Drawing.Color.Transparent;
            this.gunaTxtRepetirContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(146)))));
            this.gunaTxtRepetirContraseña.BorderRadius = 8;
            this.gunaTxtRepetirContraseña.BorderThickness = 2;
            this.gunaTxtRepetirContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTxtRepetirContraseña.DefaultText = "";
            this.gunaTxtRepetirContraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gunaTxtRepetirContraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gunaTxtRepetirContraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtRepetirContraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gunaTxtRepetirContraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtRepetirContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gunaTxtRepetirContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtRepetirContraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTxtRepetirContraseña.IconRightOffset = new System.Drawing.Point(8, 0);
            this.gunaTxtRepetirContraseña.Location = new System.Drawing.Point(76, 395);
            this.gunaTxtRepetirContraseña.Name = "gunaTxtRepetirContraseña";
            this.gunaTxtRepetirContraseña.PasswordChar = '*';
            this.gunaTxtRepetirContraseña.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtRepetirContraseña.PlaceholderText = "Repetir contraseña";
            this.gunaTxtRepetirContraseña.SelectedText = "";
            this.gunaTxtRepetirContraseña.Size = new System.Drawing.Size(331, 50);
            this.gunaTxtRepetirContraseña.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 22;
            this.guna2Panel1.Controls.Add(this.btnCancelar);
            this.guna2Panel1.Controls.Add(this.gunaTxtRepetirContraseña);
            this.guna2Panel1.Controls.Add(this.guna2ImageCheckBox1);
            this.guna2Panel1.Controls.Add(this.gunaTxtContraseña);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.gunaTxtUsuario);
            this.guna2Panel1.Controls.Add(this.lblRegistrar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.guna2Panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.Size = new System.Drawing.Size(473, 694);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Transparent;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnCancelar.BorderRadius = 10;
            this.btnCancelar.BorderThickness = 2;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(131)))), ((int)(((byte)(187)))));
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(273, 478);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 48);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(473, 694);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegister";
            this.Text = "FrmRegister";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrar;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtUsuario;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtContraseña;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtRepetirContraseña;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}