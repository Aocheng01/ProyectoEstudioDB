namespace EstudioDB
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelContenedorTodo = new Guna.UI2.WinForms.Guna2Panel();
            this.pctBoxImagenLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelContenedorLoginRegister = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2PanelTitulo2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DragControl4 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelContenedorTodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagenLogin)).BeginInit();
            this.guna2PanelTitulo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(616, 723);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrarse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(389, 723);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿No tienes cuenta?";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelContenedorTodo;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panelContenedorTodo
            // 
            this.panelContenedorTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.panelContenedorTodo.Controls.Add(this.label1);
            this.panelContenedorTodo.Controls.Add(this.label2);
            this.panelContenedorTodo.Controls.Add(this.pctBoxImagenLogin);
            this.panelContenedorTodo.Controls.Add(this.panelContenedorLoginRegister);
            this.panelContenedorTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorTodo.Location = new System.Drawing.Point(0, 61);
            this.panelContenedorTodo.Name = "panelContenedorTodo";
            this.panelContenedorTodo.ShadowDecoration.BorderRadius = 90;
            this.panelContenedorTodo.ShadowDecoration.Enabled = true;
            this.panelContenedorTodo.Size = new System.Drawing.Size(1299, 792);
            this.panelContenedorTodo.TabIndex = 10;
            // 
            // pctBoxImagenLogin
            // 
            this.pctBoxImagenLogin.BackColor = System.Drawing.Color.Transparent;
            this.pctBoxImagenLogin.Image = global::EstudioDB.Properties.Resources.nws_sept_2_29_Photoroom;
            this.pctBoxImagenLogin.ImageRotate = 0F;
            this.pctBoxImagenLogin.Location = new System.Drawing.Point(35, 88);
            this.pctBoxImagenLogin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pctBoxImagenLogin.Name = "pctBoxImagenLogin";
            this.pctBoxImagenLogin.Size = new System.Drawing.Size(716, 589);
            this.pctBoxImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxImagenLogin.TabIndex = 1;
            this.pctBoxImagenLogin.TabStop = false;
            // 
            // panelContenedorLoginRegister
            // 
            this.panelContenedorLoginRegister.AutoSize = true;
            this.panelContenedorLoginRegister.FillColor = System.Drawing.Color.Transparent;
            this.panelContenedorLoginRegister.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedorLoginRegister.Location = new System.Drawing.Point(770, 29);
            this.panelContenedorLoginRegister.Name = "panelContenedorLoginRegister";
            this.panelContenedorLoginRegister.ShadowDecoration.BorderRadius = 30;
            this.panelContenedorLoginRegister.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.panelContenedorLoginRegister.ShadowDecoration.Depth = 0;
            this.panelContenedorLoginRegister.ShadowDecoration.Enabled = true;
            this.panelContenedorLoginRegister.Size = new System.Drawing.Size(457, 668);
            this.panelContenedorLoginRegister.TabIndex = 9;
            this.panelContenedorLoginRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorLoginRegister_Paint);
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this.pctBoxImagenLogin;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 60;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2PanelTitulo2
            // 
            this.guna2PanelTitulo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2PanelTitulo2.Controls.Add(this.guna2ImageButton1);
            this.guna2PanelTitulo2.Controls.Add(this.guna2ImageButton2);
            this.guna2PanelTitulo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PanelTitulo2.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelTitulo2.Name = "guna2PanelTitulo2";
            this.guna2PanelTitulo2.Size = new System.Drawing.Size(1299, 61);
            this.guna2PanelTitulo2.TabIndex = 11;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Image = global::EstudioDB.Properties.Resources.close_45dp_5985E1_FILL0_wght400_GRAD0_opsz481;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1251, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 31);
            this.guna2ImageButton1.TabIndex = 7;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Image = global::EstudioDB.Properties.Resources.minimize_45dp_5985E1_FILL0_wght400_GRAD0_opsz48;
            this.guna2ImageButton2.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton2.Location = new System.Drawing.Point(1217, 21);
            this.guna2ImageButton2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Vertical;
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton2.Size = new System.Drawing.Size(30, 39);
            this.guna2ImageButton2.TabIndex = 8;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2DragControl4
            // 
            this.guna2DragControl4.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl4.TargetControl = this.guna2PanelTitulo2;
            this.guna2DragControl4.UseTransparentDrag = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 853);
            this.Controls.Add(this.panelContenedorTodo);
            this.Controls.Add(this.guna2PanelTitulo2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelContenedorTodo.ResumeLayout(false);
            this.panelContenedorTodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxImagenLogin)).EndInit();
            this.guna2PanelTitulo2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox pctBoxImagenLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Panel panelContenedorLoginRegister;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Panel panelContenedorTodo;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelTitulo2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl4;
    }
}

