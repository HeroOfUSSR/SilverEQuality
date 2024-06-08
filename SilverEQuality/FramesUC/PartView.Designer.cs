namespace SilverEQuality.FramesUC
{
    partial class PartView
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
            labelPart = new Label();
            labelDecimal = new Label();
            numericUpDownCount = new NumericUpDown();
            labelAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // labelPart
            // 
            labelPart.AutoSize = true;
            labelPart.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPart.Location = new Point(12, 13);
            labelPart.Name = "labelPart";
            labelPart.Size = new Size(141, 19);
            labelPart.TabIndex = 32;
            labelPart.Text = "Наименование";
            // 
            // labelDecimal
            // 
            labelDecimal.AutoSize = true;
            labelDecimal.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDecimal.Location = new Point(12, 41);
            labelDecimal.Name = "labelDecimal";
            labelDecimal.Size = new Size(177, 16);
            labelDecimal.TabIndex = 33;
            labelDecimal.Text = "Децимальный номер";
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCount.Location = new Point(263, 22);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(66, 26);
            numericUpDownCount.TabIndex = 34;
            numericUpDownCount.ValueChanged += numericUpDownCount_ValueChanged;
            // 
            // labelAmount
            // 
            labelAmount.Anchor = AnchorStyles.Right;
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmount.Location = new Point(263, 24);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(53, 19);
            labelAmount.TabIndex = 35;
            labelAmount.Text = "1234";
            // 
            // PartView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownCount);
            Controls.Add(labelDecimal);
            Controls.Add(labelPart);
            Name = "PartView";
            Size = new Size(339, 73);
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPart;
        private Label labelDecimal;
        private NumericUpDown numericUpDownCount;
        private Label labelAmount;
    }
}
