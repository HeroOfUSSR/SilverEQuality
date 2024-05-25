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
    public partial class OrderView : UserControl
    {
        private Order orderView;
        bool isExpanding = true;
        public OrderView(Order order)
        {
            InitializeComponent();
            orderView = order;
            InitView(orderView);
        }

        private void InitView(Order order)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (order.ManufacturerOrderNavigation.ImageManufacturer != null)
                    pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(order.ManufacturerOrderNavigation.ImageManufacturer));
                labelOrderNumber.Text = $"Заказ №{order.IdOrder}";

                if (order.PriorityOrder != null)
                    labelPriority.Text = db.Priorities.FirstOrDefault(x => x.IdPriority == order.PriorityOrder).TitlePriority;
                else
                    labelPriority.Text = "Без приоритета";

                labelStatus.Text = db.Statuses.FirstOrDefault(x => x.IdStatus == order.StatusOrder).TitleStatus;


            }

        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            timerExpand.Start();
        }

        private void timerExpand_Tick(object sender, EventArgs e)
        {
            if (isExpanding)
            {
                Width += 15;
                Height += 15;

                if (Width == MaximumSize.Width && Height == MaximumSize.Height)
                {
                    isExpanding = false;
                    timerExpand.Stop();
                    buttonImageMan.Visible = true;
                }
            }
            else
            {
                Width -= 10;
                Height -= 10;
                if (Width == MinimumSize.Width && Height == MinimumSize.Height)
                {
                    isExpanding = true;
                    timerExpand.Stop();
                    buttonImageMan.Visible = false;
                }
            }
        }


        private void OrderView_Load(object sender, EventArgs e)
        {

        }

        private void buttonImageMan_Click(object sender, EventArgs e)
        {
            if (openFileDialogImageChange.ShowDialog() != DialogResult.OK) return;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var newImage = File.ReadAllBytes(openFileDialogImageChange.FileName);
                var manufacturer = db.Manufacturers.FirstOrDefault(x => x.IdManufacturer == orderView.ManufacturerOrder);

                manufacturer.ImageManufacturer = newImage;

                db.Manufacturers.Update(manufacturer);
                db.SaveChanges();

                pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(newImage));
            }
        }
    }
}
