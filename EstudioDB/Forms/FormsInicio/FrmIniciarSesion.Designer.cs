namespace EstudioDB.Forms.FormsInicio
{
    partial class FrmIniciarSesion
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.gunaTxtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIniciarSesion = new Guna.UI2.WinForms.Guna2Button();
            this.gunaTxtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblIniciarSesion = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 22;
            this.guna2Panel1.Controls.Add(this.guna2ImageCheckBox1);
            this.guna2Panel1.Controls.Add(this.gunaTxtContraseña);
            this.guna2Panel1.Controls.Add(this.btnIniciarSesion);
            this.guna2Panel1.Controls.Add(this.gunaTxtUsuario);
            this.guna2Panel1.Controls.Add(this.lblIniciarSesion);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 30;
            this.guna2Panel1.Size = new System.Drawing.Size(482, 719);
            this.guna2Panel1.TabIndex = 1;
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
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(359, 355);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ImageCheckBox1.TabIndex = 8;
            this.guna2ImageCheckBox1.UseTransparentBackground = true;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
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
            this.gunaTxtContraseña.Location = new System.Drawing.Point(74, 344);
            this.gunaTxtContraseña.Name = "gunaTxtContraseña";
            this.gunaTxtContraseña.PasswordChar = '*';
            this.gunaTxtContraseña.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtContraseña.PlaceholderText = "Contraseña";
            this.gunaTxtContraseña.SelectedText = "";
            this.gunaTxtContraseña.Size = new System.Drawing.Size(331, 50);
            this.gunaTxtContraseña.TabIndex = 6;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Animated = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.btnIniciarSesion.BorderRadius = 10;
            this.btnIniciarSesion.BorderThickness = 2;
            this.btnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIniciarSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(176)))));
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(74, 421);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(331, 49);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
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
            this.gunaTxtUsuario.Location = new System.Drawing.Point(74, 269);
            this.gunaTxtUsuario.Name = "gunaTxtUsuario";
            this.gunaTxtUsuario.PasswordChar = '\0';
            this.gunaTxtUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.gunaTxtUsuario.PlaceholderText = "Usuario";
            this.gunaTxtUsuario.SelectedText = "";
            this.gunaTxtUsuario.Size = new System.Drawing.Size(331, 52);
            this.gunaTxtUsuario.TabIndex = 3;
            // 
            // lblIniciarSesion
            // 
            this.lblIniciarSesion.AutoSize = true;
            this.lblIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.lblIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.lblIniciarSesion.Location = new System.Drawing.Point(168, 185);
            this.lblIniciarSesion.Name = "lblIniciarSesion";
            this.lblIniciarSesion.Size = new System.Drawing.Size(141, 30);
            this.lblIniciarSesion.TabIndex = 2;
            this.lblIniciarSesion.Text = "Iniciar sesión";
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(482, 719);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIniciarSesion";
            this.Text = "FrmIniciarSesion";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtContraseña;
        private Guna.UI2.WinForms.Guna2Button btnIniciarSesion;
        private Guna.UI2.WinForms.Guna2TextBox gunaTxtUsuario;
        private System.Windows.Forms.Label lblIniciarSesion;
    }
}