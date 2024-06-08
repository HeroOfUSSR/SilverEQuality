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

            if (AuthForm.authorizedUser.RoleUser == 2 || AuthForm.authorizedUser.RoleUser == 4)
            {
                buttonEdit.Visible = false;
            }

            if (AuthForm.authorizedUser.RoleUser == 3)
            {
                buttonRequest.Visible = false;
            }
        }

        private void InitView(SilverType silver)
        {
            labelSilverName.Text = silver.TitleSilverType;
            labelCost.Text = $"{silver.CostPerKgSilverType} руб/кг";
            if (silver.AmountSilverType != null)
            {
                labelAmount.Text = silver.AmountSilverType.ToString();
            }
            else
            {
                labelAmount.Text = "Отсутствует на складе";
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var editSilver = new EditMaterialForm(silverView);
            editSilver.Show();
        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            var requestMaterial = new MaterialRequestForm(silverView);
            requestMaterial.ShowDialog();

        }


        private void buttonNorm_Click(object sender, EventArgs e)
        {
            silverNormShow?.Invoke(silverView);
        }


        private void panelBody_MouseEnter(object sender, EventArgs e)
        {
            //this.Size = MaximumSize;
            //BackColor = Color.Lavender;
        }

        private void panelBody_MouseLeave(object sender, EventArgs e)
        {
            //this.Size = MinimumSize;
            //BackColor = Color.White;
        }

    }
}
