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
        public MaterialView(SilverType silverType)
        {
            InitializeComponent();
            InitView(silverType);
        }

        private void InitView(SilverType silver)
        {
            labelSilverName.Text = silver.TitleSilverType;
            labelCost.Text = $"{silver.CostPerKgSilverType} руб/кг";
            labelAmount.Text = silver.AmountSilverType.ToString();

        }
    }
}
