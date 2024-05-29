using SilverEQuality.Forms;
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
        private OrderFrame orderFrame = new OrderFrame();
        private OrderAddFrame orderEditFrame = new OrderAddFrame();
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

                    orderFrame.Parent = panelBody;
                    orderFrame.Size = panelBody.Size;

                    buttonEditAdd.BackColor = Color.SteelBlue;
                    buttonEditAdd.ForeColor = Color.White;
                    break;
                case 2:
                    buttonEditAdd.BackColor = Color.White;
                    buttonEditAdd.ForeColor = Color.SteelBlue;

                    orderEditFrame.Parent = panelBody;
                    orderEditFrame.Size = panelBody.Size;

                    buttonView.BackColor = Color.SteelBlue;
                    buttonView.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
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
        }
    }
}
