using SilverEQuality.Forms;
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

namespace SilverEQuality.FramesUC
{
    public partial class MainOrderFrame : UserControl
    {
        private OrderAddFrame orderEditFrame = new OrderAddFrame();

        public event Action<Order> mainAddCheck;

        public MainOrderFrame()
        {
            InitializeComponent();
            FrameOutput(1);
        }

        private void FrameOutput(int buttonNumber)
        {
            panelBody.Controls.Clear();

            switch (buttonNumber)
            {
                case 1:
                    buttonView.BackColor = Color.White;
                    buttonView.ForeColor = Color.SteelBlue;

                    var orderFrame = new OrderFrame();
                    orderFrame.Dock = DockStyle.Fill;
                    orderFrame.Parent = panelBody;
                    orderFrame.Size = panelBody.Size;

                    orderFrame.nextAddCheck += KeepGoing;

                    buttonEditAdd.BackColor = Color.SteelBlue;
                    buttonEditAdd.ForeColor = Color.White;
                    break;
                case 2:
                    buttonEditAdd.BackColor = Color.White;
                    buttonEditAdd.ForeColor = Color.SteelBlue;

                    orderEditFrame.Dock = DockStyle.Fill;
                    orderEditFrame.Parent = panelBody;
                    orderEditFrame.Size = panelBody.Size;

                    buttonView.BackColor = Color.SteelBlue;
                    buttonView.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void KeepGoing(Order fromOrderFrame)
        {
            mainAddCheck?.Invoke(fromOrderFrame);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FrameOutput(1);
        }

        private void buttonEditAdd_Click(object sender, EventArgs e)
        {
            FrameOutput(2);
        }

        private void MainOrderFrame_Resize(object sender, EventArgs e)
        {
            /*
            if (MainForm.isMenuExpanded)
            {
                orderFrame.Width += 10;
                orderEditFrame.Width += 10;

            }
            else if (!MainForm.isMenuExpanded) 
            {
                orderFrame.Width -= 10;
                orderEditFrame.Width -= 10;
            }
            */
        }
    }
}
