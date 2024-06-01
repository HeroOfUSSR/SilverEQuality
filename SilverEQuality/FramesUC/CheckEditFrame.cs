using Microsoft.EntityFrameworkCore;
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
using System.Windows.Forms.VisualStyles;

namespace SilverEQuality.FramesUC
{
    public partial class CheckEditFrame : UserControl
    {
        private Check editCheck;
        public CheckEditFrame()
        {
            InitializeComponent();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxDepartment.DataSource = db.Departments.Where(x => x.IsAtWorkDepartment == true).ToList();
                comboBoxTypeSilver.DataSource = db.SilverTypes.ToList();
                comboBoxDecimal.DataSource = db.DecimalNumbers.ToList();
                comboBoxOrder.DataSource = db.Orders.Include(x => x.StatusOrderNavigation)
                    .Where(x => x.StatusOrderNavigation.IdStatus == 2).ToList();

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
            buttonAdd.Text = "Завершить";

            var index = comboBoxOrder.FindString(order.IdOrder.ToString());

            comboBoxOrder.SelectedIndex = index;
            comboBoxOrder.Enabled = false;
        }
    }
}
