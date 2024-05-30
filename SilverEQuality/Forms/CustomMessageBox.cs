using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilverEQuality.MessageBoxes
{
    public partial class CustomMessageBox : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public CustomMessageBox(string textMessage, bool cancelOption) : this()
        {
            ChangeMessageText(textMessage);

            if (cancelOption)
            {
                buttonCancel.Visible = true;
                Size = new Size(424, 183);
            }
        }


        private void ChangeMessageText(string textMessage)
        {
            textBoxNotification.Text = textMessage;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
