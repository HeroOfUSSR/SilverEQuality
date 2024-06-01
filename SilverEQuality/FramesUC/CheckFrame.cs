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

namespace SilverEQuality.Forms
{
    public partial class CheckFrame : UserControl
    {
        private DateTime fromDate;
        private DateTime toDate;

        private bool searchDate = false;
        public CheckFrame()
        {
            InitializeComponent();
            InitDatagrid();

            fromDate = dateTimePickerFrom.Value;
            toDate = dateTimePickerUntil.Value;
        }

        private void InitDatagrid()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                //var show = db.Check.OrderBy(x => x.IdCheck).ToList();
                
                var result = from check in db.Checks
                             .Where(x => x.IdCheck.ToString().Contains(textBoxSearch.Text)
                                || x.DecimalCheckNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                                || textBoxSearch.Text != "")
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

                if (searchDate)
                {
                    result = from check in db.Checks
                             .Where(x => x.IdCheck.ToString().Contains(textBoxSearch.Text)
                                && textBoxSearch.Text != ""
                                || x.DecimalCheckNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                                && textBoxSearch.Text != ""
                                || x.DateCheck >= fromDate && x.DateCheck <= toDate)
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
                }

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
            InitDatagrid();
        }

        private void buttonReportCreate_Click(object sender, EventArgs e)
        {
            if (dateTimePickerFrom.Value.ToString("d") == dateTimePickerUntil.Value.ToString("d"))
            {
                CustomMessageBox incorrectDate = new CustomMessageBox("Нельзя сформировать отчёт за один день", false);
                incorrectDate.ShowDialog();
                return;
            }


        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerUntil_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            fromDate = dateTimePickerFrom.Value;
            toDate = dateTimePickerUntil.Value;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {

                var datedChecks = db.Checks.Where(x => x.DateCheck >= fromDate && x.DateCheck <= toDate).ToList();

                if (datedChecks.Any())
                {
                    searchDate = true;
                    InitDatagrid();
                }
                else
                {
                    CustomMessageBox dateNotFound = new CustomMessageBox("Не найдено записей с такой датой", false);
                    dateNotFound.ShowDialog();
                }

            }
        }
    }
}
