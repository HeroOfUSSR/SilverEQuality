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

namespace SilverEQuality.Forms
{
    public partial class EditOrderForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        private Order editOrder;

        public EditOrderForm(Order order)
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxPrio.DisplayMember = nameof(Priority.TitlePriority);
                comboBoxPrio.ValueMember = nameof(Priority.IdPriority);
                comboBoxStatus.DisplayMember = nameof(Status.TitleStatus);
                comboBoxStatus.ValueMember = nameof(Status.IdStatus);
                comboBoxAppointed.DisplayMember = nameof(User.FullnameUser);
                comboBoxAppointed.ValueMember = nameof(User.IdUser);

                comboBoxAppointed.Items.AddRange(db.Users.Where(x => x.RoleUser == 2).ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());
                comboBoxPrio.Items.AddRange(db.Priorities.ToArray());
            }

            editOrder = order;
        }


        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;

        }

        private void EditOrderForm_Load(object sender, EventArgs e)
        {

            labelTitle.Text = $"Изменение заказа №{editOrder.IdOrder}";
            buttonDone.Text = "Редактировать";

            var index = comboBoxPrio.FindString(editOrder.StatusOrderNavigation.TitleStatus.ToString());

            comboBoxStatus.SelectedIndex = index;

            if (editOrder.PriorityOrder !=  null)
            {
                index = comboBoxPrio.FindString(editOrder.PriorityOrderNavigation.TitlePriority.ToString());

                comboBoxPrio.SelectedIndex = index;
            }
            

            if (editOrder.DateEndOrder != null)
                dateTimePickerEnd.Value = (DateTime)editOrder.DateEndOrder;

            textBoxDesc.Text = editOrder.DescOrder;
            textBoxPayment.Text = editOrder.PaymentOrder.ToString();
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {

                    editOrder.DateEndOrder = dateTimePickerEnd.Value;
                    editOrder.StatusOrder = ((Status)comboBoxStatus.SelectedItem).IdStatus;
                    editOrder.PriorityOrder = ((Priority)comboBoxPrio.SelectedItem).IdPriority;
                    editOrder.DescOrder = textBoxDesc.Text;
                    editOrder.AppointedOrder = ((User)comboBoxAppointed.SelectedItem).IdUser;
                    editOrder.PaymentOrder = Convert.ToDecimal(textBoxPayment.Text);

                    db.Orders.Update(editOrder);
                    db.SaveChanges();

            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
