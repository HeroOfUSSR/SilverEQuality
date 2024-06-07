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
    public partial class EditMaterialForm : Form
    {
        public bool isMouseDown;
        public Point startPoint;

        SilverEQContext db = new SilverEQContext(DBHelper.Option());

        private SilverType editType;
        public EditMaterialForm()
        {
            InitializeComponent();
        }

        public EditMaterialForm(SilverType silverType) : this()
        {
            editType = silverType;

            buttonDone.Text = "Редактировать";
            labelTitle.Text = "Изменение материала";

            textBoxCode.Text = silverType.CodeSilverType.ToString();
            if (silverType.CostPerKgSilverType != null)
            {
                textBoxCost.Text = silverType.CostPerKgSilverType.ToString();
            }

            textBoxTitleSilver.Text = silverType.TitleSilverType;
            numericUpDownAmount.Value = Convert.ToDecimal(silverType.AmountSilverType);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text == "" || textBoxTitleSilver.Text == "")
            {
                CustomMessageBox noSilverData = new CustomMessageBox("Не все поля со звёздочко заполнены", false);
                noSilverData.ShowDialog();
                return;
            }

            if (buttonDone.Text == "Редактировать")
            {
                editType.CodeSilverType = Convert.ToInt32(textBoxCode.Text);
                editType.TitleSilverType = textBoxTitleSilver.Text;
                editType.AmountSilverType = Convert.ToInt32(numericUpDownAmount.Value);
                editType.CostPerKgSilverType = Convert.ToDecimal(textBoxCost.Text);

                if (db.SilverTypes.Any(x => x.CodeSilverType == editType.CodeSilverType))
                {
                    CustomMessageBox sameCodeError = new CustomMessageBox("Такой код уже существует", false);
                    sameCodeError.ShowDialog();
                    return;
                }

                db.SilverTypes.Update(editType);
                db.SaveChanges();

                CustomMessageBox newSilver = new CustomMessageBox($"{editType.TitleSilverType} изменено", false);
                newSilver.ShowDialog();
            }
            else
            {
                if (db.SilverTypes.Any(x => x.CodeSilverType.ToString() == textBoxCode.Text))
                {
                    CustomMessageBox sameCodeError = new CustomMessageBox("Такой код уже существует", false);
                    sameCodeError.ShowDialog();
                    return;
                }
                SilverType newSilverType = new SilverType
                {
                    CodeSilverType = Convert.ToInt32(textBoxCode.Text),
                    TitleSilverType = textBoxTitleSilver.Text,
                    AmountSilverType = Convert.ToInt32(numericUpDownAmount.Value),
                    CostPerKgSilverType = Convert.ToDecimal(textBoxCost.Text),
                };

                db.SilverTypes.Add(newSilverType);
                db.SaveChanges();

                CustomMessageBox newSilver = new CustomMessageBox("Новый материал добавлен", false);
                newSilver.ShowDialog();
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

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void textBoxCost_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textBoxCode_KeyDown(object sender, KeyEventArgs e)
        {
            char digit = Convert.ToChar(e.KeyCode);

            if (!Char.IsDigit(digit) || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
