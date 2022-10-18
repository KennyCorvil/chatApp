using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace lmitp
{
    public partial class Form1 : Form
    {

        //to make the form's corners round
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        //to make the form's corners round
        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        public Point mouseLocation;
        public Form1()
        {
            InitializeComponent();
            //to make the form's corners round
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        public void loadmidform(object Form)
        {
            int newWidth = 256;
            //resize the mainpanel
            this.mainpanel.MaximumSize = new Size(694, this.mainpanel.Height);
            this.mainpanel.Size = new Size(694, this.mainpanel.Height);

            //resize the midpanel
            this.panelMid.MaximumSize = new Size(newWidth, this.panelMid.Height);
            this.panelMid.Size = new Size(newWidth, this.panelMid.Height);

            if (this.panelMid.Controls.Count > 0)
                this.panelMid.Controls.RemoveAt(0);
            
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Right;
            this.panelMid.Controls.Add(f);
            this.panelMid.Tag = f;
            f.Show();
        }


        private void btndashbaord_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            loadmidform(new midPanelForm());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            loadform(new chat());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //mousedown event to make the form draggable
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        //mousemove event to make the form draggable
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
           
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {

        }
    }
}
