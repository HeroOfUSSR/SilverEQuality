using Microsoft.EntityFrameworkCore;
using SilverEQuality.Forms;
using SilverEQuality.MessageBoxes;
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
        public readonly Order orderView;
        bool isExpanding = true;

        public event Action<Order> createCheck;
        public event Action<bool> reloadView;

        public OrderAddFrame orderEditFrame;

        public OrderView(Order order)
        {
            InitializeComponent();
            orderView = order;
            InitView(orderView);

            if (AuthForm.authorizedUser.RoleUser == 2 || AuthForm.authorizedUser.RoleUser == 4)
            {
                buttonImageMan.Visible = false;
                buttonEdit.Visible = false;
                buttonCheck.Visible = false;
            }

            Width = 821;
        }

        //public Order Order => orderView;

        private void InitView(Order order)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                textBoxDesc.Visible = false;

                if (order.ManufacturerOrderNavigation.ImageManufacturer != null)
                    pictureBoxAvatar.Image = Image.FromStream(new MemoryStream(order.ManufacturerOrderNavigation.ImageManufacturer));
                labelOrderNumber.Text = $"Заказ №{order.IdOrder}";

                if (order.PriorityOrder != null)
                {
                    labelPriority.Text = $"Приоритет: {db.Priorities.FirstOrDefault(x => x.IdPriority == order.PriorityOrder).TitlePriority}";

                }
                else
                {
                    labelPriority.Text = "Без приоритета";

                }

                if (order.DescOrder == null || order.DescOrder == "")
                {
                    textBoxDesc.Text = "Описание заказа отсутствует";
                }
                else
                {
                    textBoxDesc.Text = order.DescOrder;
                }

                labelStatus.Text = $"Статус: {db.Statuses.FirstOrDefault(x => x.IdStatus == order.StatusOrder).TitleStatus}";

                labelManufacturer.Text = db.Manufacturers.FirstOrDefault(x => x.IdManufacturer == order.ManufacturerOrder).NameManufacturer;

                var partsInWork = db.PartNecessaries.Where(x => x.OrderNecessary == order.IdOrder).ToList();

                if (partsInWork.Any())
                {
                    foreach (var partInWork in partsInWork)
                    {
                        var part = db.Parts.FirstOrDefault(x => x.IdPart == partInWork.PartNecessary1);
                        PartView partView = new PartView(part, partInWork.AmountNecessary);
                        partView.Parent = flowLayoutPanelOrderParts;
                    }
                }
                else
                {
                    buttonNotFound.Visible = true;
                }

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
                if (!MainForm.isMenuExpanded) Width += 15;
                Height += 15;

                if (Width == MaximumSize.Width && Height == MaximumSize.Height
                    || Height == MaximumSize.Height && MainForm.isMenuExpanded)
                {
                    isExpanding = false;
                    timerExpand.Stop();
                    if (AuthForm.authorizedUser.RoleUser != 2 && AuthForm.authorizedUser.RoleUser != 4)
                    {
                        buttonImageMan.Visible = true;
                        buttonEdit.Visible = true;
                        buttonCheck.Visible = true;
                    }
                    buttonComments.Visible = true;
                    textBoxDesc.Visible = true;
                    if (!MainForm.isMenuExpanded)
                    {
                        flowLayoutPanelOrderParts.Enabled = true;
                        flowLayoutPanelOrderParts.Visible = true;
                        flowLayoutPanelOrderParts.Size = MaximumSize;
                    }
                    
                }
            }
            else
            {
                if (!MainForm.isMenuExpanded) Width -= 15;
                Height -= 15;
                if (Width == MinimumSize.Width && Height == MinimumSize.Height
                    || Height == MinimumSize.Height && MainForm.isMenuExpanded)
                {
                    isExpanding = true;
                    timerExpand.Stop();
                    if (AuthForm.authorizedUser.RoleUser != 2 && AuthForm.authorizedUser.RoleUser != 4)
                    {
                        buttonImageMan.Visible = false;
                        buttonEdit.Visible = false;
                        buttonCheck.Visible = false;
                    }
                    textBoxDesc.Visible = false;
                    buttonComments.Visible = false;

                    if (!MainForm.isMenuExpanded)
                    {
                        flowLayoutPanelOrderParts.Enabled = false;
                        flowLayoutPanelOrderParts.Visible = false;
                        flowLayoutPanelOrderParts.Size = MinimumSize;
                    }
                    
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //orderEditFrame = new OrderEditFrame(orderView);
            var editForm = new EditOrderForm(orderView);
            editForm.Show();

        }

        private void buttonComments_Click(object sender, EventArgs e)
        {
            CommentForm commentForm = new CommentForm(orderView);
            commentForm.ShowDialog();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (orderView.StatusOrderNavigation.IdStatus != 3)
            {
                createCheck?.Invoke(orderView);
            }
        }

        private void OrderView_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}
