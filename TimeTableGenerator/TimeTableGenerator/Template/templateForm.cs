using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableGenerator.Template
{
    public partial class templateForm : Form
    {
        public templateForm()
        {
            InitializeComponent();
        }
        private bool maximized;
        private int mouseX = 0;
        private int mouseY= 0;
        private bool mouseDown;
        private void topPanelMover_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void topPanelMover_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X-mouseX, MousePosition.Y-mouseY);
            }
        }

        private void topPanelMover_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximze_Click(object sender, EventArgs e)
        {
            if(!maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void templateForm_Load(object sender, EventArgs e)
        {
            maximized = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
