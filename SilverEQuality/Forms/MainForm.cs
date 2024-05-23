using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.Forms
{
    public partial class MainForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        bool isExpanded = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void slideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                slideBar.Width -= 10;

                if (slideBar.Width == slideBar.MinimumSize.Width)
                {
                    isExpanded = false;
                    slideBarTimer.Stop();
                }
            }
            else
            {
                slideBar.Width += 10;
                if (slideBar.Width == slideBar.MaximumSize.Width)
                {
                    isExpanded = true;
                    slideBarTimer.Stop();
                }
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            slideBarTimer.Start();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}
