﻿using Microsoft.EntityFrameworkCore;
using SilverEQuality.MessageBoxes;
using SilverEQuality_Context;
using SilverEQuality_Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SilverEQuality.FramesUC
{
    public partial class CheckEditFrame : UserControl
    {
        private Check editCheck;
        private Order orderReport;
        public CheckEditFrame()
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxDepartment.DataSource = db.Departments.Where(x => x.IsAtWorkDepartment == true).ToList();
                comboBoxTypeSilver.DataSource = db.SilverTypes.ToList();
                comboBoxDecimal.DataSource = db.DecimalNumbers.ToList();
                comboBoxOrder.DataSource = db.Orders.Include(x => x.StatusOrderNavigation)
                    .Where(x => x.StatusOrderNavigation.IdStatus != 3).ToList();

                comboBoxDepartment.DisplayMember = nameof(Department.CodeDepartment);
                comboBoxDepartment.ValueMember = nameof(Department.CodeDepartment);

                comboBoxTypeSilver.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxTypeSilver.ValueMember = nameof(SilverType.CodeSilverType);

                comboBoxOrder.DisplayMember = nameof(Order.IdOrder);
                comboBoxOrder.ValueMember = nameof(Order.IdOrder);

                comboBoxDecimal.DisplayMember = nameof(DecimalNumber.TitleDecimal);
                comboBoxDecimal.ValueMember = nameof(DecimalNumber.IdDecimal);

                comboBoxDecimal.SelectedValue = 0;
                comboBoxDepartment.SelectedValue = 0;
                comboBoxTypeSilver.SelectedValue = 0;
                comboBoxOrder.SelectedValue = 0;
            }
        }

        public CheckEditFrame(Check check) : this()
        {
            buttonAdd.Text = "Редактировать";

            maskedTextBoxNorm.Text = check.NormCheck.ToString();
            //textBoxNumber.Text = check.NumberCheck;
            comboBoxDepartment.SelectedItem = check.DepartmentCheck;
            comboBoxTypeSilver.Text = check.SilverTypeCheck.ToString();
            comboBoxDecimal.SelectedItem = check.DecimalCheck;
            maskedTextBoxCoverage.Text = check.CoverageCheck.ToString();
            numericUpDownAmount.Value = Convert.ToDecimal(check.AmountCheck);
            //textBoxOrder.Text = check.OrderCheck;

            editCheck = check;
        }

        public CheckEditFrame(Order order) : this()
        {
            buttonAdd.Text = "Создать чек";

            var index = comboBoxOrder.FindString(order.IdOrder.ToString());

            comboBoxOrder.SelectedIndex = index;
            comboBoxOrder.Enabled = false;
            //checkBoxFinish.Visible = true;
            orderReport = order;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            DateTime dateCheck;
            DecimalNumber decimalNumber;

            if (checkBoxDate.Checked == true)
            {
                dateCheck = dateTimePickerCheck.Value;
            }
            else
            {
                dateCheck = DateTime.Now;
            }

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (db.Departments.FirstOrDefault(x => x.CodeDepartment.ToString() == comboBoxDepartment.Text) == null)
                {
                    CustomMessageBox noDepartmentFound = new CustomMessageBox("Указанный цех не найден", false);
                    noDepartmentFound.ShowDialog();
                    return;
                }
                if (db.DecimalNumbers.FirstOrDefault(x => x.TitleDecimal == comboBoxDepartment.Text) == null)
                {

                    CustomMessageBox noDecimalFound = new CustomMessageBox("Указанный децимальный номер не найден, добавить?", true);
                    noDecimalFound.ShowDialog();
                    if (noDecimalFound.DialogResult == DialogResult.OK)
                    {
                        DecimalNumber newDecimal = new DecimalNumber
                        {
                            TitleDecimal = comboBoxDecimal.Text,
                        };

                        db.DecimalNumbers.Add(newDecimal);
                        db.SaveChanges();

                        decimalNumber = db.DecimalNumbers.OrderBy(x => x.IdDecimal).Last();
                    }
                    else
                    {
                        CustomMessageBox selectValid = new CustomMessageBox("Выберите валидный децимальный номер", false);
                        selectValid.ShowDialog();
                        return;
                    }
                }
                else
                {
                    decimalNumber = ((DecimalNumber)comboBoxDecimal.SelectedItem);
                }

                if (buttonAdd.Text == "Создать чек")
                {
                    Check newCheck = new Check
                    {
                        DateCheck = dateCheck,
                        DepartmentCheck = ((Department)comboBoxDepartment.SelectedItem).CodeDepartment,
                        NormCheck = Convert.ToDecimal(maskedTextBoxNorm.Text),
                        SilverTypeCheck = ((SilverType)comboBoxTypeSilver.SelectedItem).CodeSilverType,
                        CoverageCheck = Convert.ToDecimal(maskedTextBoxCoverage.Text),
                        AmountCheck = Convert.ToInt32(numericUpDownAmount.Value),
                        DecimalCheck = decimalNumber.IdDecimal,
                        OrderCheck = ((Order)comboBoxOrder.SelectedItem).IdOrder,
                    };

                    db.Checks.Add(newCheck);
                    db.SaveChanges();
                    CustomMessageBox successAdd = new CustomMessageBox("Успешное добавление", false);
                    successAdd.Show();
                }
                if (buttonAdd.Text == "Редактировать")
                {
                    editCheck.DateCheck = dateCheck;
                    editCheck.DepartmentCheck = ((Department)comboBoxDepartment.SelectedItem).CodeDepartment;
                    editCheck.NormCheck = Convert.ToDecimal(maskedTextBoxNorm.Text);
                    editCheck.SilverTypeCheck = ((SilverType)comboBoxTypeSilver.SelectedItem).CodeSilverType;
                    editCheck.CoverageCheck = Convert.ToDecimal(maskedTextBoxCoverage.Text);
                    editCheck.AmountCheck = Convert.ToInt32(numericUpDownAmount.Value);
                    editCheck.DecimalCheck = decimalNumber.IdDecimal;
                    editCheck.OrderCheck = ((Order)comboBoxOrder.SelectedItem).IdOrder;

                    db.Checks.Update(editCheck);
                    db.SaveChanges();
                    CustomMessageBox successEdit = new CustomMessageBox($"Чек №{editCheck.IdCheck} изменён", false);
                    successEdit.Show();
                }

                if (checkBoxFinish.Checked)
                {
                    if (orderReport == null)
                        orderReport = db.Orders.FirstOrDefault(x => x.IdOrder == db.Checks.OrderBy(x => x.IdCheck).Last().OrderCheck);

                    orderReport.StatusOrder = 3;
                    orderReport.DateClosedOrder = DateTime.Now;

                    db.Orders.Update(orderReport);
                    db.SaveChanges();
                }
            }
        }

        private void checkBoxChoose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDate.Checked == true)
            {
                dateTimePickerCheck.Enabled = true;
            }
            else
            {
                dateTimePickerCheck.Enabled = false;
            }
        }

        private void maskedTextBoxNorm_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void maskedTextBoxCoverage_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}