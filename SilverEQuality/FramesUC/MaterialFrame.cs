using SilverEQuality.Forms;
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
    public partial class MaterialFrame : UserControl
    {
        public event Action<SilverType> nextAddSilver;
        public MaterialFrame()
        {
            InitializeComponent();
            InitView();
        }

        private void InitView()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var silverTypes = db.SilverTypes.OrderBy(x => x.CodeSilverType).ToList();

                foreach (var silver in silverTypes)
                {
                    var materialView = new MaterialView(silver);
                    materialView.Parent = flowLayoutPanelSilver;

                    materialView.silverNormShow += KeepGoing;

                }
            }
        }

        private void KeepGoing(SilverType fromSilverView)
        {
            nextAddSilver?.Invoke(fromSilverView);
        }

        private void flowLayoutPanelSilver_MouseEnter(object sender, EventArgs e)
        {
            if (sender is MaterialView materialView)
            {
                this.Size = MaximumSize;
                BackColor = Color.Lavender;
            }
        }

        private void flowLayoutPanelSilver_MouseLeave(object sender, EventArgs e)
        {
            if (sender is MaterialView)
            {
                this.Size = MinimumSize;
                BackColor = Color.White;
            }
        }

        private void MaterialFrame_SizeChanged(object sender, EventArgs e)
        {

        }

        private void MaterialFrame_Resize(object sender, EventArgs e)
        {
            if (!MainForm.isMenuExpanded)
            {
                panelLeftSide.Visible = false;
                panelRightSide.Visible = false;
            }
            else
            {
                panelLeftSide.Visible = true;
                panelRightSide.Visible = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newMaterial = new EditMaterialForm();
            newMaterial.ShowDialog();
        }
    }
}
