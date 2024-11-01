using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudioDB.Forms
{
    public partial class FrmTimer : Form
    {
        public FrmTimer()
        {
            InitializeComponent();
            guna2BorderlessForm1 = new Guna2BorderlessForm();
            guna2BorderlessForm1.ContainerControl = this;

            this.Load += FrmTimer_Load;
        }

        private void FrmTimer_Load(object sender, EventArgs e)
        {
            int radius = 70; 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Esquina superior izquierda
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), 270, 90); // Esquina superior derecha
            path.AddLine(this.Width, radius, this.Width, this.Height); // Lado derecho
            path.AddLine(this.Width, this.Height, radius, this.Height); // Lado inferior
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
