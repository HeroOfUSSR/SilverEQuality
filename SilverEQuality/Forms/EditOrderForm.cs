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

        public EditOrderForm()
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxManufacturer.DisplayMember = nameof(Manufacturer.NameManufacturer);
                comboBoxManufacturer.ValueMember = nameof(Manufacturer.IdManufacturer);
                comboBoxPrio.DisplayMember = nameof(Priority.TitlePriority);
                comboBoxPrio.ValueMember = nameof(Priority.IdPriority);
                comboBoxStatus.DisplayMember = nameof(Status.TitleStatus);
                comboBoxStatus.ValueMember = nameof(Status.IdStatus);
                comboBoxAppointed.DisplayMember = nameof(User.FullnameUser);
                comboBoxAppointed.ValueMember = nameof(User.IdUser);

                comboBoxAppointed.Items.AddRange(db.Users.Where(x => x.RoleUser == 2).ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());
                comboBoxPrio.Items.AddRange(db.Priorities.ToArray());
                comboBoxManufacturer.Items.AddRange(db.Manufacturers.ToArray());
            }
        }

        public EditOrderForm(Order order) : this()
        {
            editOrder = order;

            labelTitle.Text = $"Изменение заказа №{order.IdOrder}";
            buttonDone.Text = "Редактировать";

            comboBoxManufacturer.SelectedValue = order.ManufacturerOrder;
            comboBoxPrio.SelectedValue = order.PriorityOrder;
            comboBoxStatus.SelectedValue = order.StatusOrder;

            dateTimePickerStart.Value = order.DateOrder;
            if (order.DateEndOrder != null)
                dateTimePickerEnd.Value = (DateTime)order.DateEndOrder;

            textBoxDesc.Text = order.DescOrder;
            textBoxPayment.Text = order.PaymentOrder.ToString();

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

        }

        private void checkBoxTodayDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodayDate.Checked)
            {
                dateTimePickerStart.Enabled = false;
            }
            else dateTimePickerStart.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (buttonDone.Text == "Редактировать")
                {
                    editOrder.DateOrder = dateTimePickerStart.Value;
                    editOrder.DateEndOrder = dateTimePickerEnd.Value;
                    editOrder.StatusOrder = ((Status)comboBoxStatus.SelectedItem).IdStatus;
                    editOrder.PriorityOrder = ((Priority)comboBoxPrio.SelectedItem).IdPriority;
                    editOrder.DescOrder = textBoxDesc.Text;
                    editOrder.ManufacturerOrder = ((Manufacturer)comboBoxManufacturer.SelectedItem).IdManufacturer;
                    editOrder.AppointedOrder = ((User)comboBoxAppointed.SelectedItem).IdUser;
                    editOrder.PaymentOrder = Convert.ToDecimal(textBoxPayment.Text);

                    db.Orders.Update(editOrder);
                    db.SaveChanges();
                }
                else
                {
                    DateTime dateOrder;
                    if (checkBoxTodayDate.Checked)
                    {
                        dateOrder = DateTime.Now;
                    }
                    else dateOrder = dateTimePickerStart.Value;

                    var newOrder = new Order
                    {
                        DateOrder = dateOrder,
                        DateEndOrder = dateTimePickerEnd.Value,
                        ManufacturerOrder = ((Manufacturer)comboBoxManufacturer.SelectedItem).IdManufacturer,
                        StatusOrder = ((Status)comboBoxStatus.SelectedItem).IdStatus,
                        PriorityOrder = ((Priority)comboBoxPrio.SelectedItem).IdPriority,
                        DescOrder = textBoxDesc.Text,
                        AppointedOrder = ((User)comboBoxAppointed.SelectedItem).IdUser,
                        PaymentOrder = Convert.ToDecimal(textBoxPayment.Text)
                    };

                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                }
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
