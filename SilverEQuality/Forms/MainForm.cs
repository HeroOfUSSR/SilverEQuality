using SilverEQuality.FramesUC;
using SilverEQuality.MessageBoxes;
using SilverEQuality_Context.Models;
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
        private int menuButton = 1;

        public static bool isMenuExpanded = true;

        private ProfileFrame profileFrame = new ProfileFrame();
        private MainCheckFrame checkFrame = new MainCheckFrame();
        private MainOrderFrame orderFrame = new MainOrderFrame();
        private MainNormFrame normFrame = new MainNormFrame();
        private MainMaterialFrame materialFrame = new MainMaterialFrame();

        public MainForm()
        {
            InitializeComponent();
            FrameOutput();
        }

        private void slideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuExpanded)
            {
                slideBar.Width -= 10;
                if (slideBar.Width == slideBar.MinimumSize.Width)
                {
                    isMenuExpanded = false;
                    slideBarTimer.Stop();
                }
            }
            else
            {
                slideBar.Width += 10;

                if (slideBar.Width == slideBar.MaximumSize.Width)
                {
                    isMenuExpanded = true;
                    slideBarTimer.Stop();
                }
            }
        }

        private void FrameOutput()
        {
            panelFrame.Controls.Clear();

            switch (menuButton)
            {
                case 1:
                    profileFrame.Size = panelFrame.Size;
                    profileFrame.Dock = DockStyle.Fill;
                    profileFrame.Parent = panelFrame;
                    break;
                case 2:
                    checkFrame.Size = panelFrame.Size;
                    checkFrame.Dock = DockStyle.Fill;
                    checkFrame.Parent = panelFrame;
                    break;
                case 3:
                    orderFrame.Size = panelFrame.Size;
                    orderFrame.Dock = DockStyle.Fill;
                    orderFrame.Parent = panelFrame;

                    orderFrame.mainAddCheck += FinishOrder;

                    break;
                case 4:
                    normFrame.Size = panelFrame.Size;
                    normFrame.Dock = DockStyle.Fill;
                    normFrame.Parent = panelFrame;
                    break;
                case 5:
                    materialFrame.Size = panelFrame.Size;
                    materialFrame.Dock = DockStyle.Fill;
                    materialFrame.Parent = panelFrame;
                    break;

            }
        }

        private void FinishOrder(Order finishOrder)
        {
            panelFrame.Controls.Clear();

            MainCheckFrame finishCheckFrame = new MainCheckFrame(finishOrder);

            finishCheckFrame.Size = panelFrame.Size;
            finishCheckFrame.Dock = DockStyle.Fill;
            finishCheckFrame.Parent = panelFrame;


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

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            menuButton = 1;
            FrameOutput();
        }

        private void buttonChecks_Click(object sender, EventArgs e)
        {
            menuButton = 2;
            FrameOutput();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            menuButton = 3;
            FrameOutput();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            CustomMessageBox logoutMessage = new CustomMessageBox("Выйти из аккаунта?", true);
            logoutMessage.ShowDialog();
            if (logoutMessage.DialogResult == DialogResult.OK)
            {
                var auth = Application.OpenForms[0];
                auth.Show();
                this.Close();
                //AuthForm authForm = new AuthForm();
                //authForm.Show();
                //this.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var auth = Application.OpenForms[0];
            auth.Close();
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void buttonNorms_Click(object sender, EventArgs e)
        {
            menuButton = 4;
            FrameOutput();
        }

        private void slideBar_Resize(object sender, EventArgs e)
        {
            /*
            if (isMenuExpanded)
            {
                profileFrame.Width += 10;
                checkFrame.Width += 10;
                orderFrame.Width += 10;
                normFrame.Width += 10;
            } 
            else if (!isMenuExpanded)
            {
                profileFrame.Width -= 10;
                checkFrame.Width -= 10;
                orderFrame.Width -= 10;
                normFrame.Width -= 10;

            }
            */
        }

        private void buttonMaterials_Click(object sender, EventArgs e)
        {
            menuButton = 5;
            FrameOutput();
        }
    }
}
