using SilverEQuality_Context;
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
        public CheckFrame()
        {
            InitializeComponent();
        }

        public void InitDatagrid()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                //var show = db.Check.OrderBy(x => x.IdCheck).ToList();
                var result = from check in db.Checks
                             .Where(x => x.NumberCheck.Contains(textBoxSearch.Text)
                                || x.DecimalCheckNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                                || textBoxSearch.Text == "")
                             select new
                             {
                                 IdCheck = check.IdCheck,
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
                }
                else
                {
                    MessageBox.Show("Не найдено ни одной записи");
                }

                dataGridCheck.Columns["IdCheck"].HeaderText = "Идентификатор чека";
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
        }
    }
}
