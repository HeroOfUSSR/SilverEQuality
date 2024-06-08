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
using static System.ComponentModel.Design.ObjectSelectorEditor;

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

            if (AuthForm.authorizedUser.RoleUser == 4)
            {
                checkBoxEditMode.Visible = false;
            }
            if (AuthForm.authorizedUser.RoleUser == 3)
            {
                panelWork.Visible = false;
            }
        }

        public NormFrame(SilverType silverType) : this()
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var resultSilver = from norm in db.Norms
                             .Where(x => x.SilverTypeNorm == silverType.CodeSilverType)
                                   select new
                                   {
                                       IdNorm = norm.IdNorm,
                                       DecimalNorm = norm.DecimalNormNavigation.TitleDecimal,
                                       SilverTypeNorm = norm.SilverTypeNormNavigation.TitleSilverType,
                                       TitleNorm = norm.TitleNorm,
                                   };

                if (resultSilver.Any())
                {
                    dataGridViewNorm.DataSource = resultSilver.ToList();

                    dataGridViewNorm.Columns["IdNorm"].HeaderText = "Идентификатор";
                    dataGridViewNorm.Columns["IdNorm"].Visible = false;

                    dataGridViewNorm.Columns["DecimalNorm"].HeaderText = "Децимальный номер";
                    dataGridViewNorm.Columns["SilverTypeNorm"].HeaderText = "Вид серебра";
                    dataGridViewNorm.Columns["TitleNorm"].HeaderText = "Норма";
                }
                else
                {
                    CustomMessageBox noNorms = new CustomMessageBox("Нормы не найдены", false);
                    noNorms.ShowDialog();
                }
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
                else
                {
                    CustomMessageBox noNorms = new CustomMessageBox("Нормы не найдены", false);
                    noNorms.ShowDialog();
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
                        DecimalNorm = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal,
                        SilverTypeNorm = ((SilverType)comboBoxSilverType.SelectedItem).CodeSilverType,
                        TitleNorm = Convert.ToDecimal(maskedTextBoxNorm.Text),
                    };

                    db.Norms.Add(newNorm);
                    db.SaveChanges();

                    CustomMessageBox successAdd = new CustomMessageBox("Норма добавлена", false);
                    successAdd.ShowDialog();

                    InitDatagrid();
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

                maskedTextBoxNorm.Text = "";
                comboBoxDecimal.SelectedValue = 0;
                comboBoxSilverType.SelectedValue = 0;
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var selected = Convert.ToInt32(dataGridViewNorm.Rows[dataGridViewNorm.SelectedRows[0].Index].Cells[0].Value);

                var editNorm = db.Norms.FirstOrDefault(x => x.IdNorm == selected);

                if (editNorm != null)
                {
                    editNorm.DecimalNorm = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal;
                    editNorm.SilverTypeNorm = ((SilverType)comboBoxSilverType.SelectedItem).CodeSilverType;
                    editNorm.TitleNorm = Convert.ToDecimal(maskedTextBoxNorm.Text);

                    db.Norms.Update(editNorm);
                    db.SaveChanges();

                    CustomMessageBox successAdd = new CustomMessageBox("Норма изменена", false);
                    successAdd.ShowDialog();

                    //InitDatagrid();
                }
            else
            {
                CustomMessageBox noData = new CustomMessageBox("Не выделена норма для редактирования", false);
                noData.ShowDialog();
            }
        }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var db = new SilverEQContext(DBHelper.Option()))
            {
                var selected = Convert.ToInt32(dataGridViewNorm.Rows[dataGridViewNorm.SelectedRows[0].Index].Cells[0].Value);

                var deleteNorm = db.Norms.FirstOrDefault(x => x.IdNorm == selected);

                if (deleteNorm != null)
                {
                    deleteNorm.DecimalNorm = ((DecimalNumber)comboBoxDecimal.SelectedItem).IdDecimal;
                    deleteNorm.SilverTypeNorm = ((SilverType)comboBoxSilverType.SelectedItem).CodeSilverType;
                    deleteNorm.TitleNorm = Convert.ToDecimal(maskedTextBoxNorm.Text);

                    db.Norms.Remove(deleteNorm);
                    db.SaveChanges();

                    CustomMessageBox successAdd = new CustomMessageBox("Норма удалена", false);
                    successAdd.ShowDialog();

                    //InitDatagrid();
                }
                else
                {
                    CustomMessageBox noData = new CustomMessageBox("Не выделена норма для удаления", false);
                    noData.ShowDialog();
                }
            }
        }
    }
}
