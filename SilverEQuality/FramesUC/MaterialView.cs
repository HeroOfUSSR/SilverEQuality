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

        private void MaterialView_MouseEnter(object sender, EventArgs e)
        {

        }

        private void MaterialView_MouseLeave(object sender, EventArgs e)
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
            this.Size = MinimumSize;
            BackColor = Color.White;
        }
    }
}
