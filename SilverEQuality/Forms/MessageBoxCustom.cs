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
    public partial class MessageBoxCustom : Form
    {
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        public MessageBoxCustom(string textMessage) : this()
        {
            ChangeMessageText(textMessage);
        }

        private void ChangeMessageText(string textMessage)
        {
            labelErrorMes.Text = textMessage;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
