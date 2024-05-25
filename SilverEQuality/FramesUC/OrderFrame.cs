﻿using Microsoft.EntityFrameworkCore;
using SilverEQuality.FramesUC;
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

                comboBoxManuf.DisplayMember = nameof(Manufacturer.NameManufacturer);
                comboBoxManuf.ValueMember = nameof(Manufacturer.IdManufacturer);
                comboBoxPriority.DisplayMember = nameof(Priority.TitlePriority);
                comboBoxPriority.ValueMember = nameof(Priority.IdPriority);
                comboBoxStatus.DisplayMember = nameof(Status.TitleStatus);
                comboBoxStatus.ValueMember = nameof(Status.IdStatus);

                comboBoxManuf.Items.AddRange(db.Manufacturers.ToArray());
                comboBoxPriority.Items.AddRange(db.Priorities.ToArray());
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());


                comboBoxManuf.Items.Insert(0, new Manufacturer
                {
                    IdManufacturer = 0,
                    NameManufacturer = "Все заказчики"
                });
                comboBoxPriority.Items.Insert(0, new Priority
                {
                    IdPriority = 0,
                    TitlePriority = "Все приоритеты"
                });
                comboBoxStatus.Items.Insert(0, new Status
                {
                    IdStatus = 0,
                    TitleStatus = "Все статусы"
                });

                foreach (var order in orders)
                {
                    var orderView = new OrderView(order);
                    orderView.Parent = flowLayoutPanelOrder;
                }
            }
        }

        private void Filter()
        {
            if (comboBoxManuf.SelectedItem == null) return;

            var selectedManufacturer = ((Manufacturer)comboBoxManuf.SelectedItem).IdManufacturer;
            var selectedStatus = ((Status)comboBoxStatus.SelectedItem).IdStatus;
            var selectedPriority = ((Priority)comboBoxPriority.SelectedItem).IdPriority;

            foreach (var item in flowLayoutPanelOrder.Controls)
            {
                var visible = true;
                if (item is OrderView orderView)
                {
                    if (selectedManufacturer != 0 &&
                        !(orderView.orderView.ManufacturerOrder == selectedManufacturer))
                    {
                        visible = false;
                    }

                    if (selectedStatus != 0 &&
                        !(orderView.orderView.StatusOrder == selectedStatus))
                    {
                        visible = false;
                    }

                    if (selectedPriority != 0 &&
                        !(orderView.orderView.PriorityOrder == selectedPriority))
                    {
                        visible = false;
                    }

                    if (!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        orderView.orderView.IdOrder.ToString().Contains(textBoxSearch.Text)))
                    {
                        visible = false;
                    }

                    orderView.Visible = visible;
                }
            }
        }

        private void comboBoxManuf_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void comboBoxSortDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
