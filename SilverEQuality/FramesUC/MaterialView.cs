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
    public partial class MaterialView : UserControl
    {
        private SilverType silverView;

        public event Action<SilverType> silverNormShow;

        private int timer;
        public MaterialView(SilverType silverType)
        {
            InitializeComponent();
            InitView(silverType);
            silverView = silverType;
        }

        private void InitView(SilverType silver)
        {
            labelSilverName.Text = silver.TitleSilverType;
            labelCost.Text = $"{silver.CostPerKgSilverType} руб/кг";
            labelAmount.Text = silver.AmountSilverType.ToString();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editSilver = new EditMaterialForm(silverView);
            editSilver.Show();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {

        }


        private void buttonNorm_Click(object sender, EventArgs e)
        {
            silverNormShow?.Invoke(silverView);
        }


        private void panelBody_MouseEnter(object sender, EventArgs e)
        {
            this.Size = MaximumSize;
            BackColor = Color.Lavender;
        }

        private void panelBody_MouseLeave(object sender, EventArgs e)
        {
            timer = 0;
            timerHover.Start();
        }

        private void panelBody_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void timerHover_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer >= 3)
            {
                this.Size = MinimumSize;
                BackColor = Color.White;
                timerHover.Stop();
            }
        }

        private void buttonNorm_MouseEnter(object sender, EventArgs e)
        {
            timerHover.Stop();

        }

        private void buttonRequest_MouseEnter(object sender, EventArgs e)
        {
            timerHover.Stop();

        }

        private void buttonNorm_MouseLeave(object sender, EventArgs e)
        {
            timerHover.Start();

        }

        private void buttonRequest_MouseLeave(object sender, EventArgs e)
        {
            timerHover.Start();

        }

        private void buttonEdit_MouseLeave(object sender, EventArgs e)
        {
            timerHover.Start();

        }

        private void buttonEdit_MouseEnter(object sender, EventArgs e)
        {
            timerHover.Stop();

        }

        private void labelSilverName_MouseEnter(object sender, EventArgs e)
        {
            timerHover.Stop();
        }

        private void labelSilverName_MouseLeave(object sender, EventArgs e)
        {
            timerHover.Start();

        }

        private void labelAmount_MouseEnter(object sender, EventArgs e)
        {
            timerHover.Stop();
        }

        private void labelAmount_MouseLeave(object sender, EventArgs e)
        {
            timerHover.Start();

        }
    }
}
