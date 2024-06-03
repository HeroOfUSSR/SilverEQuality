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
    }
}
