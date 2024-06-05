using DGVPrinterHelper;
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
using System.Windows.Forms.VisualStyles;

namespace SilverEQuality.Forms
{
    public partial class CheckFrame : UserControl
    {
        private DateTime fromDate;
        private DateTime toDate;

        private int sortChecks;
        private bool searchDate = false;
        public CheckFrame()
        {
            InitializeComponent();
            

            fromDate = dateTimePickerFrom.Value;
            toDate = dateTimePickerUntil.Value;

            comboBoxSortDate.DisplayMember = "Text";
            comboBoxSortDate.ValueMember = "Value";

            comboBoxSortDate.Items.Add(new { Text = "Самые новые", Value = 1 });
            comboBoxSortDate.Items.Add(new { Text = "Самые старые", Value = 2 });

            comboBoxSortDate.SelectedValue = 0;
            sortChecks = comboBoxSortDate.SelectedIndex;

            InitDatagrid(sortChecks);
        }

        private void InitDatagrid(int sort)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                //var show = db.Check.OrderBy(x => x.IdCheck).ToList();

                var query = db.Checks
                             .Where(x => x.IdCheck.ToString().Contains(textBoxSearch.Text)
                                || x.DecimalCheckNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                                || textBoxSearch.Text == "");

                if (searchDate)
                {
                    query = query.Where(x => x.DateCheck >= fromDate && x.DateCheck <= toDate);
                }

                switch (sort)
                {
                    case 0:
                        query.OrderByDescending(c => c.DateCheck.Ticks);
                            //.ThenBy(c => c.DateCheck.TimeOfDay);
                        //.OrderBy(x => x.DateCheck);
                        break;
                    case 1:
                        query.OrderBy(c => c.DateCheck.Ticks);
                            //.ThenBy(c => c.DateCheck.TimeOfDay);
                        break;
                }

                var result = from check in query
                             select new
                             {
                                 //IdCheck = check.IdCheck,
                                 NumberCheck = check.NumberCheck,
                                 DateCheck = check.DateCheck,
                                 DepartmentCheck = check.DepartmentCheck,
                                 NormCheck = check.NormCheck,
                                 SilverTypeCheck = db.SilverTypes.FirstOrDefault(x => x.CodeSilverType == check.SilverTypeCheck).TitleSilverType,
                                 CoverageCheck = check.CoverageCheck,
                                 AmountCheck = check.AmountCheck,
                                 DecimalCheck = db.DecimalNumbers.FirstOrDefault(x => x.IdDecimal == check.DecimalCheck).TitleDecimal,
                                 OrderCheck = check.OrderCheck,
                             };

                if (result.Any())
                {
                    dataGridCheck.DataSource = result.ToList();

                    //dataGridCheck.Columns["IdCheck"].HeaderText = "Идентификатор чека";
                    dataGridCheck.Columns["NumberCheck"].HeaderText = "Номер чека";
                    dataGridCheck.Columns["DateCheck"].HeaderText = "Дата чека";
                    dataGridCheck.Columns["DepartmentCheck"].HeaderText = "Номер цеха";
                    dataGridCheck.Columns["NormCheck"].HeaderText = "Норма серебра";
                    dataGridCheck.Columns["SilverTypeCheck"].HeaderText = "Вид серебра";
                    dataGridCheck.Columns["CoverageCheck"].HeaderText = "Площадь покрытия";
                    dataGridCheck.Columns["AmountCheck"].HeaderText = "Количество";
                    dataGridCheck.Columns["DecimalCheck"].HeaderText = "Децимальный номер";
                    dataGridCheck.Columns["OrderCheck"].HeaderText = "Номер заказа";
                }
                else
                {
                    CustomMessageBox checksNotFound = new CustomMessageBox("Не найдено записей", false);
                    checksNotFound.ShowDialog();
                }

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            sortChecks = comboBoxSortDate.SelectedIndex;

            InitDatagrid(sortChecks);

            if (checkBoxNorm.Checked)
            {
                using (var db = new SilverEQContext(DBHelper.Option()))
                {
                    foreach (DataGridViewRow row in dataGridCheck.Rows)
                    {
                        var correctNorm = db.Norms.FirstOrDefault(x => x.DecimalNormNavigation.TitleDecimal == row.Cells[7].Value.ToString());

                        if (correctNorm != null)
                            if (correctNorm.TitleNorm.ToString() != row.Cells[3].Value.ToString()
                                || correctNorm.SilverTypeNorm.ToString() != row.Cells[4].Value.ToString()) // Тут надо позор с ToString как то переделать
                                dataGridCheck.Rows[row.Index].DefaultCellStyle.BackColor = Color.IndianRed; // P.S. Decimal.Compare не работает, потому что nullable в моделях
                    }
                }
            }
        }

        private void buttonReportCreate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.ToString("d") == dateTimePickerUntil.Value.ToString("d"))
            {
                CustomMessageBox incorrectDate = new CustomMessageBox("Нельзя сформировать отчёт за один день", false);
                incorrectDate.ShowDialog();
                return;
            }

            var printReports = new DGVPrinter();
            printReports.CreateReport("Отчёт", dataGridCheck, fromDate, toDate);
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            fromDate = dateTimePickerFrom.Value;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (db.Checks.Where(x => x.DateCheck >= fromDate && x.DateCheck <= toDate).Any())
                {
                    searchDate = true;
                    InitDatagrid(sortChecks);
                }
            }
        }

        private void dateTimePickerUntil_ValueChanged(object sender, EventArgs e)
        {
            toDate = dateTimePickerUntil.Value;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                if (db.Checks.Where(x => x.DateCheck >= fromDate && x.DateCheck <= toDate).Any())
                {
                    searchDate = true;
                    InitDatagrid(sortChecks);
                }
            }
        }

        private void buttonCheckDate_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxNorm_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
