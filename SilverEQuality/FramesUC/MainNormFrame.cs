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
    public partial class MainNormFrame : UserControl
    {
        public MainNormFrame()
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
                    buttonNormView.BackColor = Color.White;
                    buttonNormView.ForeColor = Color.SteelBlue;
                    var normFrame = new NormFrame();
                    normFrame.Parent = panelBody;
                    buttonDocuments.BackColor = Color.SteelBlue;
                    buttonDocuments.ForeColor = Color.White;
                    break;
                case 2:
                    buttonDocuments.BackColor = Color.White;
                    buttonDocuments.ForeColor = Color.SteelBlue;
                    var docsFrame = new DocumentsFrame();
                    docsFrame.Parent = panelBody;
                    buttonNormView.BackColor = Color.SteelBlue;
                    buttonNormView.ForeColor = Color.White;
                    break;
                default:
                    break;

            }
        }

        private void buttonNormView_Click(object sender, EventArgs e)
        {
            FrameOutput(1);
        }

        private void buttonDocuments_Click(object sender, EventArgs e)
        {
            FrameOutput(2);
        }
    }
}
