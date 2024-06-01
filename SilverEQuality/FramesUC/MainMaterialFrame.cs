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
    public partial class MainMaterialFrame : UserControl
    {
        private MaterialFrame materialFrame = new MaterialFrame();
        private MaterialRequestFrame requestFrame = new MaterialRequestFrame();

        public MainMaterialFrame()
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

                    materialFrame.Size = panelBody.Size;
                    materialFrame.Dock = DockStyle.Fill;
                    materialFrame.Parent = panelBody;

                    buttonRequests.BackColor = Color.SteelBlue;
                    buttonRequests.ForeColor = Color.White;
                    break;
                case 2:
                    buttonRequests.BackColor = Color.White;
                    buttonRequests.ForeColor = Color.SteelBlue;

                    requestFrame.Size = panelBody.Size;
                    requestFrame.Dock = DockStyle.Fill;
                    requestFrame.Parent = panelBody;

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

        private void buttonRequests_Click(object sender, EventArgs e)
        {
            FrameOutput(2);
        }
    }
}
