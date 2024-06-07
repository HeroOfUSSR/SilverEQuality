using Microsoft.EntityFrameworkCore;
using SilverEQuality_Context;
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
    public partial class MaterialRequestFrame : UserControl
    {
        public MaterialRequestFrame()
        {
            InitializeComponent();
            InitFlow();
        }

        private void InitFlow()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var reqs = db.SilverRequests.OrderByDescending(x => x.IdRequest)
                    .Include(x => x.StatusRequestNavigation)
                    .Include(x => x.PriorityRequestNavigation).ToList();

                foreach (var req in reqs)
                {
                    var reqView = new RequestView(req);
                    reqView.Parent = flowLayoutPanelRequests;
                }
            }
        }
    }
}
