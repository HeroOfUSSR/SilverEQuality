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
    public partial class MainCheckFrame : UserControl
    {
        public MainCheckFrame()
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
                    buttonGrid.BackColor = Color.White;
                    buttonGrid.ForeColor = Color.SteelBlue;
                    var checkFrame = new CheckFrame();
                    checkFrame.Parent = panelBody;
                    buttonGraphs.BackColor = Color.SteelBlue;
                    buttonGraphs.ForeColor = Color.White;
                    break;
                case 2:
                    buttonGraphs.BackColor = Color.White;
                    buttonGraphs.ForeColor = Color.SteelBlue;
                    var graphFrame = new GraphFrame();
                    graphFrame.Parent = panelBody;
                    buttonGrid.BackColor = Color.SteelBlue;
                    buttonGrid.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            FrameOutput(1);
        }

        private void buttonGraphs_Click(object sender, EventArgs e)
        {
            FrameOutput(2);
        }
    }
}
