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
            checkBoxFinish = new CheckBox();
            checkBoxDate = new CheckBox();
            label9 = new Label();
            dateTimePickerCheck = new DateTimePicker();
            comboBoxOrder = new ComboBox();
            label8 = new Label();
            comboBoxDecimal = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            numericUpDownAmount = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            comboBoxDepartment = new ComboBox();
            label3 = new Label();
            comboBoxTypeSilver = new ComboBox();
            label2 = new Label();
            numericUpDownNorm = new NumericUpDown();
            numericUpDownCoverage = new NumericUpDown();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNorm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoverage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 18);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonAdd);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(841, 70);
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
            buttonAdd.Location = new Point(252, 19);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(355, 37);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Создать чек";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(numericUpDownCoverage);
            panel3.Controls.Add(numericUpDownNorm);
            panel3.Controls.Add(checkBoxFinish);
            panel3.Controls.Add(checkBoxDate);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(dateTimePickerCheck);
            panel3.Controls.Add(comboBoxOrder);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(comboBoxDecimal);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(numericUpDownAmount);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBoxDepartment);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxTypeSilver);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 360);
            panel3.TabIndex = 2;
            // 
            // checkBoxFinish
            // 
            checkBoxFinish.Anchor = AnchorStyles.None;
            checkBoxFinish.AutoSize = true;
            checkBoxFinish.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxFinish.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFinish.Location = new Point(339, 331);
            checkBoxFinish.Name = "checkBoxFinish";
            checkBoxFinish.Size = new Size(182, 23);
            checkBoxFinish.TabIndex = 18;
            checkBoxFinish.Text = "Заказ завершён";
            checkBoxFinish.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxFinish.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            checkBoxDate.Anchor = AnchorStyles.None;
            checkBoxDate.AutoSize = true;
            checkBoxDate.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDate.Location = new Point(361, 260);
            checkBoxDate.Name = "checkBoxDate";
            checkBoxDate.Size = new Size(160, 23);
            checkBoxDate.TabIndex = 17;
            checkBoxDate.Text = "Выбрать дату";
            checkBoxDate.UseVisualStyleBackColor = true;
            checkBoxDate.CheckedChanged += checkBoxChoose_CheckedChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(284, 294);
            label9.Name = "label9";
            label9.Size = new Size(130, 19);
            label9.TabIndex = 16;
            label9.Text = "Дата заказа";
            // 
            // dateTimePickerCheck
            // 
            dateTimePickerCheck.Anchor = AnchorStyles.None;
            dateTimePickerCheck.Enabled = false;
            dateTimePickerCheck.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCheck.Location = new Point(432, 289);
            dateTimePickerCheck.Name = "dateTimePickerCheck";
            dateTimePickerCheck.Size = new Size(224, 26);
            dateTimePickerCheck.TabIndex = 7;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.Anchor = AnchorStyles.None;
            comboBoxOrder.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxOrder.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxOrder.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(432, 18);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(153, 27);
            comboBoxOrder.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(273, 21);
            label8.Name = "label8";
            label8.Size = new Size(141, 19);
            label8.TabIndex = 15;
            label8.Text = "Номер заказа";
            // 
            // comboBoxDecimal
            // 
            comboBoxDecimal.Anchor = AnchorStyles.None;
            comboBoxDecimal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDecimal.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDecimal.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDecimal.FormattingEnabled = true;
            comboBoxDecimal.Location = new Point(432, 221);
            comboBoxDecimal.Name = "comboBoxDecimal";
            comboBoxDecimal.Size = new Size(224, 27);
            comboBoxDecimal.TabIndex = 5;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(218, 224);
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
            label6.Location = new Point(295, 191);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 12;
            label6.Text = "Количество";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Anchor = AnchorStyles.None;
            numericUpDownAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(432, 188);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(89, 26);
            numericUpDownAmount.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(230, 160);
            label5.Name = "label5";
            label5.Size = new Size(185, 19);
            label5.TabIndex = 10;
            label5.Text = "Площадь покрытия";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(219, 95);
            label4.Name = "label4";
            label4.Size = new Size(196, 19);
            label4.TabIndex = 8;
            label4.Text = "Фактическая норма";
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Anchor = AnchorStyles.None;
            comboBoxDepartment.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDepartment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(432, 59);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(89, 27);
            comboBoxDepartment.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(296, 62);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 5;
            label3.Text = "Номер цеха";
            // 
            // comboBoxTypeSilver
            // 
            comboBoxTypeSilver.Anchor = AnchorStyles.None;
            comboBoxTypeSilver.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeSilver.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeSilver.FormattingEnabled = true;
            comboBoxTypeSilver.Location = new Point(432, 124);
            comboBoxTypeSilver.Name = "comboBoxTypeSilver";
            comboBoxTypeSilver.Size = new Size(192, 27);
            comboBoxTypeSilver.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(285, 127);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 3;
            label2.Text = "Тип серебра";
            // 
            // numericUpDownNorm
            // 
            numericUpDownNorm.DecimalPlaces = 6;
            numericUpDownNorm.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownNorm.Location = new Point(432, 92);
            numericUpDownNorm.Name = "numericUpDownNorm";
            numericUpDownNorm.Size = new Size(120, 26);
            numericUpDownNorm.TabIndex = 38;
            // 
            // numericUpDownCoverage
            // 
            numericUpDownCoverage.DecimalPlaces = 5;
            numericUpDownCoverage.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownCoverage.Location = new Point(432, 157);
            numericUpDownCoverage.Name = "numericUpDownCoverage";
            numericUpDownCoverage.Size = new Size(120, 26);
            numericUpDownCoverage.TabIndex = 39;
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
            Size = new Size(841, 448);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNorm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCoverage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBoxTypeSilver;
        private Label label2;
        private Label label5;
        private Label label4;
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
        private CheckBox checkBoxDate;
        private CheckBox checkBoxFinish;
        private NumericUpDown numericUpDownCoverage;
        private NumericUpDown numericUpDownNorm;
    }
}
