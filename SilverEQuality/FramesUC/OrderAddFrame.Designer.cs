namespace SilverEQuality.FramesUC
{
    partial class OrderAddFrame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.comboBoxAppointed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPrio = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxManufacturer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.checkBoxTodayDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxNoEndDate = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelParts = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 18);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDone);
            this.panel2.Controls.Add(this.comboBoxAppointed);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 50);
            this.panel2.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDone.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDone.Location = new System.Drawing.Point(545, 6);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(364, 37);
            this.buttonDone.TabIndex = 23;
            this.buttonDone.Text = "Добавить";
            this.buttonDone.UseVisualStyleBackColor = false;
            // 
            // comboBoxAppointed
            // 
            this.comboBoxAppointed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAppointed.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxAppointed.FormattingEnabled = true;
            this.comboBoxAppointed.Location = new System.Drawing.Point(257, 12);
            this.comboBoxAppointed.Name = "comboBoxAppointed";
            this.comboBoxAppointed.Size = new System.Drawing.Size(200, 27);
            this.comboBoxAppointed.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Ответственный";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(144, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Описание";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDesc.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDesc.Location = new System.Drawing.Point(264, 166);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(200, 84);
            this.textBoxDesc.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(144, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Оплата";
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPayment.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPayment.Location = new System.Drawing.Point(264, 268);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(200, 26);
            this.textBoxPayment.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(144, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Приоритет";
            // 
            // comboBoxPrio
            // 
            this.comboBoxPrio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPrio.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPrio.FormattingEnabled = true;
            this.comboBoxPrio.Location = new System.Drawing.Point(264, 133);
            this.comboBoxPrio.Name = "comboBoxPrio";
            this.comboBoxPrio.Size = new System.Drawing.Size(200, 27);
            this.comboBoxPrio.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(144, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Статус*";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxStatus.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(264, 100);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 27);
            this.comboBoxStatus.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(144, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Заказчик*";
            // 
            // comboBoxManufacturer
            // 
            this.comboBoxManufacturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxManufacturer.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxManufacturer.FormattingEnabled = true;
            this.comboBoxManufacturer.Location = new System.Drawing.Point(264, 48);
            this.comboBoxManufacturer.Name = "comboBoxManufacturer";
            this.comboBoxManufacturer.Size = new System.Drawing.Size(200, 27);
            this.comboBoxManufacturer.TabIndex = 30;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEnd.Location = new System.Drawing.Point(549, 27);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerEnd.TabIndex = 29;
            // 
            // checkBoxTodayDate
            // 
            this.checkBoxTodayDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTodayDate.AutoSize = true;
            this.checkBoxTodayDate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxTodayDate.Location = new System.Drawing.Point(281, 53);
            this.checkBoxTodayDate.Name = "checkBoxTodayDate";
            this.checkBoxTodayDate.Size = new System.Drawing.Size(146, 20);
            this.checkBoxTodayDate.TabIndex = 28;
            this.checkBoxTodayDate.Text = "Текущая дата";
            this.checkBoxTodayDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStart.Location = new System.Drawing.Point(257, 26);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerStart.TabIndex = 27;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(436, -1);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(141, 19);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Дата заказа:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(492, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "-";
            // 
            // checkBoxNoEndDate
            // 
            this.checkBoxNoEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxNoEndDate.AutoSize = true;
            this.checkBoxNoEndDate.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNoEndDate.Location = new System.Drawing.Point(585, 53);
            this.checkBoxNoEndDate.Name = "checkBoxNoEndDate";
            this.checkBoxNoEndDate.Size = new System.Drawing.Size(116, 20);
            this.checkBoxNoEndDate.TabIndex = 44;
            this.checkBoxNoEndDate.Text = "Бессрочно";
            this.checkBoxNoEndDate.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePickerEnd);
            this.panel4.Controls.Add(this.labelDate);
            this.panel4.Controls.Add(this.checkBoxNoEndDate);
            this.panel4.Controls.Add(this.dateTimePickerStart);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.checkBoxTodayDate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1009, 80);
            this.panel4.TabIndex = 46;
            // 
            // flowLayoutPanelParts
            // 
            this.flowLayoutPanelParts.AutoScroll = true;
            this.flowLayoutPanelParts.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanelParts.Name = "flowLayoutPanelParts";
            this.flowLayoutPanelParts.Size = new System.Drawing.Size(364, 214);
            this.flowLayoutPanelParts.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Поиск необходимых деталей";
            this.textBox1.Size = new System.Drawing.Size(364, 26);
            this.textBox1.TabIndex = 48;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.flowLayoutPanelParts);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(545, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 286);
            this.panel5.TabIndex = 49;
            // 
            // OrderAddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.comboBoxManufacturer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBoxPrio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.label8);
            this.MaximumSize = new System.Drawing.Size(1009, 448);
            this.MinimumSize = new System.Drawing.Size(841, 448);
            this.Name = "OrderAddFrame";
            this.Size = new System.Drawing.Size(1009, 448);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
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
        private Label labelDate;
        private Label label10;
        private CheckBox checkBoxNoEndDate;
        private Panel panel4;
        private FlowLayoutPanel flowLayoutPanelParts;
        private TextBox textBox1;
        private Panel panel5;
    }
}
