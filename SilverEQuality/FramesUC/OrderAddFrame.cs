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
    public partial class OrderAddFrame : UserControl
    {
        private Dictionary<Part, int> partMap;

        public OrderAddFrame()
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

                partMap = new Dictionary<Part, int>();

                var parts = db.Parts.OrderByDescending(x => x.IdPart);

                foreach (var part in parts)
                {
                    PartView partView = new PartView(part);
                    partView.Parent = flowLayoutPanelParts;

                    partView.PartAdded += PartView_PartAdded;
                }
            }
        }


        private void PartView_PartAdded(object sender, (Part, int) e)
        {
            if (partMap.TryGetValue(e.Item1, out var count))
            {
                partMap[e.Item1] = ++count;
            }
            else partMap.Add(e.Item1, e.Item2);
        }



        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (comboBoxManufacturer.SelectedIndex == -1 || comboBoxStatus.SelectedIndex == -1)
                {
                    CustomMessageBox errorOrder = new CustomMessageBox("Введите данные во все поля со звёздочкой", false);
                    errorOrder.ShowDialog();
                    return;
                }

                string paymentOrder;

                if (textBoxPayment.Text != "")
                {
                    paymentOrder = textBoxPayment.Text;
                }
                else
                {
                    paymentOrder = null;
                }

                int priority;

                if (comboBoxPrio.SelectedItem != null)
                {
                    priority = ((Priority)comboBoxPrio.SelectedItem).IdPriority;
                }
                else priority = db.Priorities.FirstOrDefault(x => x.IdPriority == 2).IdPriority;

                int? appointed = null;

                if (comboBoxAppointed.SelectedItem != null)
                {
                    appointed = ((User)comboBoxAppointed.SelectedItem).IdUser;
                }
                var newOrder = new Order
                {
                    DateOrder = dateTimePickerStart.Value,
                    DateEndOrder = dateTimePickerEnd.Value,
                    ManufacturerOrder = ((Manufacturer)comboBoxManufacturer.SelectedItem).IdManufacturer,
                    StatusOrder = ((Status)comboBoxStatus.SelectedItem).IdStatus,
                    PriorityOrder = priority,
                    DescOrder = textBoxDesc.Text,
                    AppointedOrder = appointed,
                    PaymentOrder = Convert.ToDecimal(paymentOrder)
                };

                if (checkBoxTodayDate.Checked)
                {
                    newOrder.DateOrder = DateTime.Now;
                }
                if (checkBoxNoEndDate.Checked)
                {
                    newOrder.DateEndOrder = null;
                }

                db.Orders.Add(newOrder);
                db.SaveChanges();

                var orderParts = db.Orders.OrderBy(x => x.IdOrder).Last();

                foreach (var item in partMap.Keys)
                {
                    PartNecessary newUserParts = new PartNecessary
                    {
                        AmountNecessary = partMap[item],
                        PartNecessary1 = item.IdPart,
                        OrderNecessary = orderParts.IdOrder,
                    };

                    //var removeParts = db.Parts.FirstOrDefault(x => x.IdPart == item.IdPart);
                    //removeParts.AmountPart -= partMap[item];

                    //db.Parts.Update(removeParts);
                    db.PartNecessaries.Add(newUserParts);
                    db.SaveChanges();
                }

                CustomMessageBox successAdd = new CustomMessageBox($"Заказ №{db.Orders.OrderBy(x => x.IdOrder).Last().IdOrder} успешно создан", false);
                successAdd.ShowDialog();
            }
        }

        private void textBoxPayment_KeyDown_1(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoEndDate_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxNoEndDate.Checked)
            {
                dateTimePickerEnd.Enabled = false;
            }
            else dateTimePickerEnd.Enabled = true;
        }

        private void checkBoxTodayDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodayDate.Checked)
            {
                dateTimePickerStart.Enabled = false;
            }
            else dateTimePickerStart.Enabled = true;
        }
    }
}
