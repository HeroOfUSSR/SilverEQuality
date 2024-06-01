namespace SilverEQuality.FramesUC
{
    partial class CheckEditFrame
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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonAdd = new Button();
            panel3 = new Panel();
            label9 = new Label();
            dateTimePickerCheck = new DateTimePicker();
            comboBoxOrder = new ComboBox();
            label8 = new Label();
            comboBoxDecimal = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            numericUpDownAmount = new NumericUpDown();
            label5 = new Label();
            maskedTextBoxCoverage = new MaskedTextBox();
            label4 = new Label();
            maskedTextBoxNorm = new MaskedTextBox();
            comboBoxDepartment = new ComboBox();
            label3 = new Label();
            comboBoxTypeSilver = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 33);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 76);
            panel2.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.BackColor = Color.SteelBlue;
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(336, 22);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(355, 37);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dateTimePickerCheck);
            panel3.Controls.Add(comboBoxOrder);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBoxDecimal);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(numericUpDownAmount);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(maskedTextBoxCoverage);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(maskedTextBoxNorm);
            panel3.Controls.Add(comboBoxDepartment);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxTypeSilver);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 339);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(368, 273);
            label9.Name = "label9";
            label9.Size = new Size(130, 19);
            label9.TabIndex = 16;
            label9.Text = "Дата заказа";
            // 
            // dateTimePickerCheck
            // 
            dateTimePickerCheck.Anchor = AnchorStyles.None;
            dateTimePickerCheck.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCheck.Location = new Point(516, 268);
            dateTimePickerCheck.Name = "dateTimePickerCheck";
            dateTimePickerCheck.Size = new Size(224, 26);
            dateTimePickerCheck.TabIndex = 7;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.Anchor = AnchorStyles.None;
            comboBoxOrder.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(516, 6);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(153, 27);
            comboBoxOrder.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(357, 9);
            label8.Name = "label8";
            label8.Size = new Size(141, 19);
            label8.TabIndex = 15;
            label8.Text = "Номер заказа";
            // 
            // comboBoxDecimal
            // 
            comboBoxDecimal.Anchor = AnchorStyles.None;
            comboBoxDecimal.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDecimal.FormattingEnabled = true;
            comboBoxDecimal.Location = new Point(516, 235);
            comboBoxDecimal.Name = "comboBoxDecimal";
            comboBoxDecimal.Size = new Size(224, 27);
            comboBoxDecimal.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(302, 238);
            label7.Name = "label7";
            label7.Size = new Size(196, 19);
            label7.TabIndex = 13;
            label7.Text = "Децимальный номер";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(379, 205);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 12;
            label6.Text = "Количество";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Anchor = AnchorStyles.None;
            numericUpDownAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(516, 202);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(89, 26);
            numericUpDownAmount.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(314, 174);
            label5.Name = "label5";
            label5.Size = new Size(185, 19);
            label5.TabIndex = 10;
            label5.Text = "Площадь покрытия";
            // 
            // maskedTextBoxCoverage
            // 
            maskedTextBoxCoverage.Anchor = AnchorStyles.None;
            maskedTextBoxCoverage.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxCoverage.Location = new Point(516, 170);
            maskedTextBoxCoverage.Mask = "0.00000";
            maskedTextBoxCoverage.Name = "maskedTextBoxCoverage";
            maskedTextBoxCoverage.Size = new Size(153, 26);
            maskedTextBoxCoverage.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(303, 109);
            label4.Name = "label4";
            label4.Size = new Size(196, 19);
            label4.TabIndex = 8;
            label4.Text = "Фактическая норма";
            // 
            // maskedTextBoxNorm
            // 
            maskedTextBoxNorm.Anchor = AnchorStyles.None;
            maskedTextBoxNorm.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxNorm.Location = new Point(516, 105);
            maskedTextBoxNorm.Mask = "0.000000";
            maskedTextBoxNorm.Name = "maskedTextBoxNorm";
            maskedTextBoxNorm.Size = new Size(121, 26);
            maskedTextBoxNorm.TabIndex = 1;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Anchor = AnchorStyles.None;
            comboBoxDepartment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(516, 73);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(89, 27);
            comboBoxDepartment.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(380, 76);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 5;
            label3.Text = "Номер цеха";
            // 
            // comboBoxTypeSilver
            // 
            comboBoxTypeSilver.Anchor = AnchorStyles.None;
            comboBoxTypeSilver.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeSilver.FormattingEnabled = true;
            comboBoxTypeSilver.Location = new Point(516, 138);
            comboBoxTypeSilver.Name = "comboBoxTypeSilver";
            comboBoxTypeSilver.Size = new Size(192, 27);
            comboBoxTypeSilver.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(369, 141);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 3;
            label2.Text = "Тип серебра";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(379, 303);
            label1.Name = "label1";
            label1.Size = new Size(119, 19);
            label1.TabIndex = 1;
            label1.Text = "Номер чека";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(516, 300);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 12;
            // 
            // CheckEditFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "CheckEditFrame";
            Size = new Size(1009, 448);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBoxTypeSilver;
        private Label label2;
        private Label label5;
        private MaskedTextBox maskedTextBoxCoverage;
        private Label label4;
        private MaskedTextBox maskedTextBoxNorm;
        private ComboBox comboBoxDepartment;
        private Label label3;
        private ComboBox comboBoxDecimal;
        private Label label7;
        private Label label6;
        private NumericUpDown numericUpDownAmount;
        private DateTimePicker dateTimePickerCheck;
        private ComboBox comboBoxOrder;
        private Label label8;
        private Label label9;
        private Button buttonAdd;
    }
}
