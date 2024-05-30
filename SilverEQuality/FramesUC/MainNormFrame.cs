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
        private NormFrame normFrame = new NormFrame();
        private DocumentsFrame docsFrame = new DocumentsFrame();
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
                    normFrame.Size = panelBody.Size;
                    normFrame.Parent = panelBody;

                    buttonDocuments.BackColor = Color.SteelBlue;
                    buttonDocuments.ForeColor = Color.White;
                    break;
                case 2:
                    buttonDocuments.BackColor = Color.White;
                    buttonDocuments.ForeColor = Color.SteelBlue;

                    docsFrame.Size = panelBody.Size;
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

        private void MainNormFrame_Resize(object sender, EventArgs e)
        {
            if (MainForm.isMenuExpanded)
            {
                normFrame.Width += 10;
                docsFrame.Width += 10;

            }
            else if (!MainForm.isMenuExpanded)
            {
                normFrame.Width -= 10;
                docsFrame.Width -= 10;
            }
        }
    }
}
