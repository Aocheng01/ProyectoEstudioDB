namespace EstudioDB.Forms
{
    partial class FrmTimer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnAñadir = new Guna.UI2.WinForms.Guna2Button();
            this.lblElegirTarea = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnFinalizar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPausar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEmpezar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.btnEliminarTarea = new Guna.UI2.WinForms.Guna2Button();
            this.panelGridView = new Guna.UI2.WinForms.Guna2Panel();
            this.daoProyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daoProyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 70;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.BorderRadius = 15;
            this.btnAñadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAñadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAñadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAñadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAñadir.ForeColor = System.Drawing.Color.White;
            this.btnAñadir.Location = new System.Drawing.Point(636, 616);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(170, 45);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir tarea";
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // lblElegirTarea
            // 
            this.lblElegirTarea.AutoSize = true;
            this.lblElegirTarea.BackColor = System.Drawing.Color.Transparent;
            this.lblElegirTarea.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirTarea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.lblElegirTarea.Location = new System.Drawing.Point(929, 37);
            this.lblElegirTarea.Name = "lblElegirTarea";
            this.lblElegirTarea.Size = new System.Drawing.Size(158, 30);
            this.lblElegirTarea.TabIndex = 5;
            this.lblElegirTarea.Text = "Elige una tarea";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(310, 636);
            this.guna2DataGridView1.TabIndex = 6;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnFinalizar);
            this.guna2Panel1.Controls.Add(this.btnPausar);
            this.guna2Panel1.Controls.Add(this.btnEmpezar);
            this.guna2Panel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel1.Controls.Add(this.btnEliminarTarea);
            this.guna2Panel1.Controls.Add(this.panelGridView);
            this.guna2Panel1.Controls.Add(this.btnAñadir);
            this.guna2Panel1.Controls.Add(this.lblElegirTarea);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1197, 753);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFinalizar.HoverState.Image = global::EstudioDB.Properties.Resources.stop_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnFinalizar.HoverState.ImageSize = new System.Drawing.Size(67, 67);
            this.btnFinalizar.Image = global::EstudioDB.Properties.Resources.stop_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnFinalizar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnFinalizar.ImageRotate = 0F;
            this.btnFinalizar.Location = new System.Drawing.Point(520, 463);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnFinalizar.Size = new System.Drawing.Size(77, 61);
            this.btnFinalizar.TabIndex = 12;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPausar.HoverState.Image = global::EstudioDB.Properties.Resources.pause_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnPausar.HoverState.ImageSize = new System.Drawing.Size(67, 67);
            this.btnPausar.Image = global::EstudioDB.Properties.Resources.pause_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnPausar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPausar.ImageRotate = 0F;
            this.btnPausar.Location = new System.Drawing.Point(367, 463);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPausar.Size = new System.Drawing.Size(78, 61);
            this.btnPausar.TabIndex = 11;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEmpezar.HoverState.Image = global::EstudioDB.Properties.Resources.play_arrow_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnEmpezar.HoverState.ImageSize = new System.Drawing.Size(67, 67);
            this.btnEmpezar.Image = global::EstudioDB.Properties.Resources.play_arrow_30dp_5985E1_FILL0_wght400_GRAD0_opsz24;
            this.btnEmpezar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEmpezar.ImageRotate = 0F;
            this.btnEmpezar.Location = new System.Drawing.Point(225, 463);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEmpezar.Size = new System.Drawing.Size(85, 64);
            this.btnEmpezar.TabIndex = 10;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblCronometro);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(143, 233);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(537, 208);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(129)))), ((int)(((byte)(194)))));
            this.lblCronometro.Location = new System.Drawing.Point(41, 36);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(464, 128);
            this.lblCronometro.TabIndex = 10;
            this.lblCronometro.Text = "00:00:00";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.BorderRadius = 15;
            this.btnEliminarTarea.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTarea.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarTarea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEliminarTarea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEliminarTarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminarTarea.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTarea.Location = new System.Drawing.Point(636, 676);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(170, 45);
            this.btnEliminarTarea.TabIndex = 8;
            this.btnEliminarTarea.Text = "Eliminar tarea";
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // panelGridView
            // 
            this.panelGridView.Controls.Add(this.guna2DataGridView1);
            this.panelGridView.Location = new System.Drawing.Point(843, 85);
            this.panelGridView.Name = "panelGridView";
            this.panelGridView.ShadowDecoration.Depth = 15;
            this.panelGridView.ShadowDecoration.Enabled = true;
            this.panelGridView.Size = new System.Drawing.Size(310, 636);
            this.panelGridView.TabIndex = 7;
            // 
            // daoProyectoBindingSource
            // 
            this.daoProyectoBindingSource.DataSource = typeof(EstudioDB.dao.DaoProyecto);
            // 
            // FrmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1197, 753);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTimer";
            this.Text = "FrmTimer";
            this.Load += new System.EventHandler(this.FrmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panelGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daoProyectoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btnAñadir;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.Label lblElegirTarea;
        private Guna.UI2.WinForms.Guna2Panel panelGridView;
        private System.Windows.Forms.BindingSource daoProyectoBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnEliminarTarea;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lblCronometro;
        private Guna.UI2.WinForms.Guna2ImageButton btnFinalizar;
        private Guna.UI2.WinForms.Guna2ImageButton btnPausar;
        private Guna.UI2.WinForms.Guna2ImageButton btnEmpezar;
    }
}