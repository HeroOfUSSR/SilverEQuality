using Microsoft.EntityFrameworkCore;
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

namespace SilverEQuality.FramesUC
{
    public partial class NormFrame : UserControl
    {
        public NormFrame()
        {
            InitializeComponent();
            InitDatagrid();

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                comboBoxDecimal.DisplayMember = nameof(DecimalNumber.TitleDecimal);
                comboBoxDecimal.ValueMember = nameof(DecimalNumber.IdDecimal);
                comboBoxSilverType.DisplayMember = nameof(SilverType.TitleSilverType);
                comboBoxSilverType.ValueMember = nameof(SilverType.CodeSilverType);

                comboBoxDecimal.Items.AddRange(db.DecimalNumbers.ToArray());
                comboBoxSilverType.Items.AddRange(db.SilverTypes.ToArray());
            }

        }

        private void InitDatagrid()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var result = from norm in db.Norms
                             .Where(x => x.DecimalNormNavigation.TitleDecimal.Contains(textBoxSearch.Text)
                             || x.SilverTypeNormNavigation.TitleSilverType.Contains(textBoxSearch.Text)
                             || textBoxSearch.Text == "")
                             select new
                             {
                                 IdNorm = norm.IdNorm,
                                 DecimalNorm = norm.DecimalNormNavigation.TitleDecimal,
                                 SilverTypeNorm = norm.SilverTypeNormNavigation.TitleSilverType,
                                 TitleNorm = norm.TitleNorm,
                             };

                if (result.Any())
                {
                    dataGridViewNorm.DataSource = result.ToList();

                    dataGridViewNorm.Columns["IdNorm"].HeaderText = "Идентификатор";
                    dataGridViewNorm.Columns["IdNorm"].Visible = false;

                    dataGridViewNorm.Columns["DecimalNorm"].HeaderText = "Децимальный номер";
                    dataGridViewNorm.Columns["SilverTypeNorm"].HeaderText = "Вид серебра";
                    dataGridViewNorm.Columns["TitleNorm"].HeaderText = "Норма";


                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDecimal.SelectedItem != null
                && comboBoxSilverType.SelectedItem != null
                && maskedTextBoxNorm.Text != "")
            {
                using (var db = new SilverEQContext(DBHelper.Option()))
                {
                    var newNorm = new Norm
                    {
                        DecimalNorm = ((Norm)comboBoxDecimal.SelectedItem).IdNorm,
                        SilverTypeNorm = ((SilverType)comboBoxSilverType.SelectedItem).CodeSilverType,
                        TitleNorm = Convert.ToDecimal(maskedTextBoxNorm.Text),
                    };

                    db.Norms.Add(newNorm);
                    db.SaveChanges();
                }
            }
            else
            {
                CustomMessageBox noData = new CustomMessageBox("Не все данные введены", false);
                noData.ShowDialog();
            }
        }

        private void checkBoxEditMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEditMode.Checked)
            {
                buttonEdit.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                buttonEdit.Visible = false;
                buttonDelete.Visible = false;
            }
        }

        private void dataGridViewNorm_SelectionChanged(object sender, EventArgs e)
        {
            if (checkBoxEditMode.Checked == false) return;

            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var selectedNorm = Convert.ToInt32(dataGridViewNorm.Rows[dataGridViewNorm.SelectedRows[0].Index].Cells[0].Value);

                var editNorm = db.Norms.Include(x => x.DecimalNormNavigation).Include(x => x.SilverTypeNormNavigation).FirstOrDefault(x => x.IdNorm == selectedNorm);

                var index = comboBoxDecimal.FindString(editNorm.DecimalNormNavigation.TitleDecimal.ToString());
                comboBoxDecimal.SelectedIndex = index;

                index = comboBoxSilverType.FindString(editNorm.SilverTypeNormNavigation.TitleSilverType.ToString());
                comboBoxSilverType.SelectedIndex = index;

                maskedTextBoxNorm.Text = editNorm.TitleNorm.ToString();

            }

        }
    }
}
