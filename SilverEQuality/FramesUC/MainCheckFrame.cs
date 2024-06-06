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
    public partial class MainCheckFrame : UserControl
    {
        private CheckFrame checkFrame = new CheckFrame();
        private GraphFrame graphFrame = new GraphFrame();
        private CheckEditFrame checkEditFrame = new CheckEditFrame();

        public MainCheckFrame()
        {
            InitializeComponent();
            FrameOutput(1);
        }
        public MainCheckFrame(Order order) : this()
        {
            panelBody.Controls.Clear();
            CheckEditFrame finishCheck = new CheckEditFrame(order);

            finishCheck.Size = panelBody.Size;
            finishCheck.Dock = DockStyle.Fill;
            finishCheck.Parent = panelBody;
        }

        private void FrameOutput(int buttonNumber)
        {
            panelBody.Controls.Clear();

            switch (buttonNumber)
            {
                case 1:
                    buttonGrid.BackColor = Color.White;
                    buttonGrid.ForeColor = Color.SteelBlue;

                    CheckFrame checkFrame = new CheckFrame();
                    checkFrame.Size = panelBody.Size;
                    checkFrame.Dock = DockStyle.Fill;
                    checkFrame.Parent = panelBody;

                    checkFrame.editingCheck += CheckFrame_editingCheck;

                    buttonAdd.BackColor = Color.SteelBlue;
                    buttonAdd.ForeColor = Color.White;
                    buttonGraphs.BackColor = Color.SteelBlue;
                    buttonGraphs.ForeColor = Color.White;
                    break;
                case 2:
                    buttonAdd.BackColor = Color.White;
                    buttonAdd.ForeColor = Color.SteelBlue;

                    CheckEditFrame checkEditFrame = new CheckEditFrame();
                    checkEditFrame.Size = panelBody.Size;
                    checkEditFrame.Dock = DockStyle.Fill;
                    checkEditFrame.Parent = panelBody;

                    buttonGrid.BackColor = Color.SteelBlue;
                    buttonGrid.ForeColor = Color.White;
                    buttonGraphs.BackColor = Color.SteelBlue;
                    buttonGraphs.ForeColor = Color.White;
                    break;
                case 3:
                    buttonGraphs.BackColor = Color.White;
                    buttonGraphs.ForeColor = Color.SteelBlue;

                    graphFrame.Size = panelBody.Size;
                    graphFrame.Dock = DockStyle.Fill;
                    graphFrame.Parent = panelBody;

                    buttonAdd.BackColor = Color.SteelBlue;
                    buttonAdd.ForeColor = Color.White;
                    buttonGrid.BackColor = Color.SteelBlue;
                    buttonGrid.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void CheckFrame_editingCheck(Check editCheck)
        {
            panelBody.Controls.Clear();

            CheckEditFrame checkEditFrame = new CheckEditFrame(editCheck);
            checkEditFrame.Size = panelBody.Size;
            checkEditFrame.Dock = DockStyle.Fill;
            checkEditFrame.Parent = panelBody;
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            FrameOutput(1);
        }

        private void MainCheckFrame_Resize(object sender, EventArgs e)
        {
            /*
            if (MainForm.isMenuExpanded)
            {
                checkFrame.Width += 10;
                graphFrame.Width += 10;

            }
            else if (!MainForm.isMenuExpanded)
            {
                checkFrame.Width -= 10;
                graphFrame.Width -= 10;
            }
            */
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FrameOutput(2);
        }

        private void buttonGraphs_Click(object sender, EventArgs e)
        {
            FrameOutput(3);
        }
    }
}
