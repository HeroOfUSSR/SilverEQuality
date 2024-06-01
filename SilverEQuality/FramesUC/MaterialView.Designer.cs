namespace SilverEQuality.FramesUC
{
    partial class MaterialView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelSilverName = new Label();
            labelAmount = new Label();
            labelCost = new Label();
            buttonEdit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelSilverName
            // 
            labelSilverName.AutoSize = true;
            labelSilverName.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilverName.Location = new Point(14, 15);
            labelSilverName.Name = "labelSilverName";
            labelSilverName.Size = new Size(229, 19);
            labelSilverName.TabIndex = 0;
            labelSilverName.Text = "Наименование серебра";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmount.Location = new Point(14, 45);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(107, 16);
            labelAmount.TabIndex = 1;
            labelAmount.Text = "Количество";
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelCost.Location = new Point(333, 32);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(97, 16);
            labelCost.TabIndex = 2;
            labelCost.Text = "Стоимость";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(467, 9);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(249, 30);
            buttonEdit.TabIndex = 24;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.DialogResult = DialogResult.OK;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(467, 42);
            button1.Name = "button1";
            button1.Size = new Size(249, 30);
            button1.TabIndex = 25;
            button1.Text = "Открыть норму";
            button1.UseVisualStyleBackColor = false;
            // 
            // MaterialView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(buttonEdit);
            Controls.Add(labelCost);
            Controls.Add(labelAmount);
            Controls.Add(labelSilverName);
            Name = "MaterialView";
            Size = new Size(719, 78);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSilverName;
        private Label labelAmount;
        private Label labelCost;
        private Button buttonEdit;
        private Button button1;
    }
}
