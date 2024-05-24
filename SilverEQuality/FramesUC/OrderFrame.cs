using Microsoft.EntityFrameworkCore;
using SilverEQuality.FramesUC;
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

namespace SilverEQuality.Forms
{
    public partial class OrderFrame : UserControl
    {
        public OrderFrame()
        {
            InitializeComponent();
        }

        private void OrderFrame_Load(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var orders = db.Orders.Include(x => x.ManufacturerOrderNavigation).ToList();

                foreach (var order in orders)
                {
                    var orderView = new OrderView(order);
                    orderView.Parent = flowLayoutPanelOrder;
                }
            }
        }
    }
}
