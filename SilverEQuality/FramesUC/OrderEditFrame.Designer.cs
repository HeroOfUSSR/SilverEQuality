namespace SilverEQuality.FramesUC
{
    partial class OrderEditFrame
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
            buttonCancel = new Button();
            buttonDone = new Button();
            label3 = new Label();
            comboBoxAppointed = new ComboBox();
            label8 = new Label();
            textBoxDesc = new TextBox();
            label7 = new Label();
            textBoxPayment = new TextBox();
            label6 = new Label();
            comboBoxPrio = new ComboBox();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            label4 = new Label();
            comboBoxManufacturer = new ComboBox();
            dateTimePickerEnd = new DateTimePicker();
            checkBoxTodayDate = new CheckBox();
            dateTimePickerStart = new DateTimePicker();
            label1 = new Label();
            label9 = new Label();
            label10 = new Label();
            checkBoxNoEndDate = new CheckBox();
            panel3 = new Panel();
            panel4 = new Panel();
            checkedListBox1 = new CheckedListBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 18);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonDone);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 50);
            panel2.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(617, 7);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(368, 33);
            buttonCancel.TabIndex = 24;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.DialogResult = DialogResult.OK;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(47, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 23;
            buttonDone.Text = "Добавить";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(508, 15);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 41;
            label3.Text = "Ответственный";
            // 
            // comboBoxAppointed
            // 
            comboBoxAppointed.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAppointed.FormattingEnabled = true;
            comboBoxAppointed.Location = new Point(666, 12);
            comboBoxAppointed.Name = "comboBoxAppointed";
            comboBoxAppointed.Size = new Size(200, 27);
            comboBoxAppointed.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(138, 226);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 39;
            label8.Text = "Описание";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(262, 226);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(200, 84);
            textBoxDesc.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(83, 187);
            label7.Name = "label7";
            label7.Size = new Size(163, 19);
            label7.TabIndex = 37;
            label7.Text = "Плата за заказ";
            // 
            // textBoxPayment
            // 
            textBoxPayment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPayment.Location = new Point(262, 184);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(200, 26);
            textBoxPayment.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(138, 146);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 35;
            label6.Text = "Приоритет";
            // 
            // comboBoxPrio
            // 
            comboBoxPrio.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPrio.FormattingEnabled = true;
            comboBoxPrio.Location = new Point(262, 143);
            comboBoxPrio.Name = "comboBoxPrio";
            comboBoxPrio.Size = new Size(200, 27);
            comboBoxPrio.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(181, 106);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 33;
            label5.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(262, 98);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 27);
            comboBoxStatus.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(159, 15);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 31;
            label4.Text = "Заказчик";
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(262, 12);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(200, 27);
            comboBoxManufacturer.TabIndex = 30;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(629, 3);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 26);
            dateTimePickerEnd.TabIndex = 29;
            dateTimePickerEnd.ValueChanged += dateTimePickerEnd_ValueChanged;
            // 
            // checkBoxTodayDate
            // 
            checkBoxTodayDate.AutoSize = true;
            checkBoxTodayDate.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTodayDate.Location = new Point(375, 37);
            checkBoxTodayDate.Name = "checkBoxTodayDate";
            checkBoxTodayDate.Size = new Size(160, 23);
            checkBoxTodayDate.TabIndex = 28;
            checkBoxTodayDate.Text = "Текущая дата";
            checkBoxTodayDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(360, 5);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 26);
            dateTimePickerStart.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(147, 11);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 25;
            label1.Text = "Дата заказа:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(334, 9);
            label9.Name = "label9";
            label9.Size = new Size(20, 19);
            label9.TabIndex = 42;
            label9.Text = "С";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(592, 10);
            label10.Name = "label10";
            label10.Size = new Size(31, 19);
            label10.TabIndex = 43;
            label10.Text = "По";
            // 
            // checkBoxNoEndDate
            // 
            checkBoxNoEndDate.AutoSize = true;
            checkBoxNoEndDate.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNoEndDate.Location = new Point(629, 37);
            checkBoxNoEndDate.Name = "checkBoxNoEndDate";
            checkBoxNoEndDate.Size = new Size(226, 23);
            checkBoxNoEndDate.TabIndex = 44;
            checkBoxNoEndDate.Text = "Без даты окончания";
            checkBoxNoEndDate.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBoxManufacturer);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(comboBoxAppointed);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 62);
            panel3.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePickerEnd);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(checkBoxNoEndDate);
            panel4.Controls.Add(dateTimePickerStart);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(checkBoxTodayDate);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 334);
            panel4.Name = "panel4";
            panel4.Size = new Size(1009, 64);
            panel4.TabIndex = 46;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(605, 116);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(292, 184);
            checkedListBox1.TabIndex = 47;
            // 
            // OrderEditFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkedListBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label8);
            Controls.Add(textBoxDesc);
            Controls.Add(label7);
            Controls.Add(textBoxPayment);
            Controls.Add(label6);
            Controls.Add(comboBoxPrio);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrderEditFrame";
            Size = new Size(1009, 448);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button buttonCancel;
        private Button buttonDone;
        private Label label3;
        private ComboBox comboBoxAppointed;
        private Label label8;
        private TextBox textBoxDesc;
        private Label label7;
        private TextBox textBoxPayment;
        private Label label6;
        private ComboBox comboBoxPrio;
        private Label label5;
        private ComboBox comboBoxStatus;
        private Label label4;
        private ComboBox comboBoxManufacturer;
        private DateTimePicker dateTimePickerEnd;
        private CheckBox checkBoxTodayDate;
        private DateTimePicker dateTimePickerStart;
        private Label label1;
        private Label label9;
        private Label label10;
        private CheckBox checkBoxNoEndDate;
        private Panel panel3;
        private Panel panel4;
        private CheckedListBox checkedListBox1;
    }
}
