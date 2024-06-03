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
    }
}
