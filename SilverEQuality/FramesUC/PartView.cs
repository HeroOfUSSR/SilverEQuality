using SilverEQuality_Context;
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
    public partial class PartView : UserControl
    {
        private EventHandler<(Part, int)> onPartAdded;

        public Part partView;
        public int count;
        public PartView()
        {
            InitializeComponent();
        }

        public PartView(Part part) : this()
        {
            InitializeComponent();
            InitView(part);

            labelAmount.Visible = false;
            this.partView = part;
        }

        public PartView(Part part, int amount) : this()
        {
            numericUpDownCount.Visible = false;
            labelAmount.Visible = true;
            labelAmount.Text = amount.ToString();
            InitView(part);
        }

        private void InitView(Part part)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                labelPart.Text = part.NamePart;
                labelDecimal.Text = db.DecimalNumbers.FirstOrDefault(x => x.IdDecimal == part.DecimalPart).TitleDecimal;
            }
        }

        public event EventHandler<(Part, int)> PartAdded
        {
            add
            {
                onPartAdded += value;
            }
            remove
            {
                onPartAdded -= value;
            }
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            count = (int)numericUpDownCount.Value;

            onPartAdded?.Invoke(this, (partView, count));
        }

    }
}
