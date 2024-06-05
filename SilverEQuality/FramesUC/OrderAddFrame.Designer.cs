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
            panel1 = new Panel();
            panel2 = new Panel();
            buttonDone = new Button();
            comboBoxAppointed = new ComboBox();
            label3 = new Label();
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
            labelDate = new Label();
            label10 = new Label();
            checkBoxNoEndDate = new CheckBox();
            panel4 = new Panel();
            flowLayoutPanelParts = new FlowLayoutPanel();
            textBox1 = new TextBox();
            panel5 = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel2.Controls.Add(buttonDone);
            panel2.Controls.Add(comboBoxAppointed);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 398);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 50);
            panel2.TabIndex = 1;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.None;
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.DialogResult = DialogResult.OK;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(545, 6);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(364, 37);
            buttonDone.TabIndex = 23;
            buttonDone.Text = "Добавить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // comboBoxAppointed
            // 
            comboBoxAppointed.Anchor = AnchorStyles.None;
            comboBoxAppointed.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAppointed.FormattingEnabled = true;
            comboBoxAppointed.Location = new Point(257, 12);
            comboBoxAppointed.Name = "comboBoxAppointed";
            comboBoxAppointed.Size = new Size(200, 27);
            comboBoxAppointed.TabIndex = 40;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(99, 15);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 41;
            label3.Text = "Ответственный";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(144, 169);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 39;
            label8.Text = "Описание";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Anchor = AnchorStyles.None;
            textBoxDesc.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(264, 166);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(200, 84);
            textBoxDesc.TabIndex = 38;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(144, 268);
            label7.Name = "label7";
            label7.Size = new Size(75, 19);
            label7.TabIndex = 37;
            label7.Text = "Оплата";
            // 
            // textBoxPayment
            // 
            textBoxPayment.Anchor = AnchorStyles.None;
            textBoxPayment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPayment.Location = new Point(264, 268);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(200, 26);
            textBoxPayment.TabIndex = 36;
            textBoxPayment.KeyDown += textBoxPayment_KeyDown;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(144, 133);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 35;
            label6.Text = "Приоритет";
            // 
            // comboBoxPrio
            // 
            comboBoxPrio.Anchor = AnchorStyles.None;
            comboBoxPrio.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPrio.FormattingEnabled = true;
            comboBoxPrio.Location = new Point(264, 133);
            comboBoxPrio.Name = "comboBoxPrio";
            comboBoxPrio.Size = new Size(200, 27);
            comboBoxPrio.TabIndex = 34;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(144, 100);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 33;
            label5.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.None;
            comboBoxStatus.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(264, 100);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 27);
            comboBoxStatus.TabIndex = 32;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(144, 48);
            label4.Name = "label4";
            label4.Size = new Size(97, 19);
            label4.TabIndex = 31;
            label4.Text = "Заказчик";
            // 
            // comboBoxManufacturer
            // 
            comboBoxManufacturer.Anchor = AnchorStyles.None;
            comboBoxManufacturer.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxManufacturer.FormattingEnabled = true;
            comboBoxManufacturer.Location = new Point(264, 48);
            comboBoxManufacturer.Name = "comboBoxManufacturer";
            comboBoxManufacturer.Size = new Size(200, 27);
            comboBoxManufacturer.TabIndex = 30;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.None;
            dateTimePickerEnd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(549, 27);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 26);
            dateTimePickerEnd.TabIndex = 29;
            // 
            // checkBoxTodayDate
            // 
            checkBoxTodayDate.Anchor = AnchorStyles.None;
            checkBoxTodayDate.AutoSize = true;
            checkBoxTodayDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTodayDate.Location = new Point(281, 53);
            checkBoxTodayDate.Name = "checkBoxTodayDate";
            checkBoxTodayDate.Size = new Size(146, 20);
            checkBoxTodayDate.TabIndex = 28;
            checkBoxTodayDate.Text = "Текущая дата";
            checkBoxTodayDate.UseVisualStyleBackColor = true;
            checkBoxTodayDate.CheckedChanged += checkBoxTodayDate_CheckedChanged;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.None;
            dateTimePickerStart.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(257, 26);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 26);
            dateTimePickerStart.TabIndex = 27;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.None;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(436, -1);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(141, 19);
            labelDate.TabIndex = 25;
            labelDate.Text = "Дата заказа:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(492, 33);
            label10.Name = "label10";
            label10.Size = new Size(20, 19);
            label10.TabIndex = 43;
            label10.Text = "-";
            // 
            // checkBoxNoEndDate
            // 
            checkBoxNoEndDate.Anchor = AnchorStyles.None;
            checkBoxNoEndDate.AutoSize = true;
            checkBoxNoEndDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxNoEndDate.Location = new Point(585, 53);
            checkBoxNoEndDate.Name = "checkBoxNoEndDate";
            checkBoxNoEndDate.Size = new Size(116, 20);
            checkBoxNoEndDate.TabIndex = 44;
            checkBoxNoEndDate.Text = "Бессрочно";
            checkBoxNoEndDate.UseVisualStyleBackColor = true;
            checkBoxNoEndDate.CheckedChanged += checkBoxNoEndDate_CheckedChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePickerEnd);
            panel4.Controls.Add(labelDate);
            panel4.Controls.Add(checkBoxNoEndDate);
            panel4.Controls.Add(dateTimePickerStart);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(checkBoxTodayDate);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 318);
            panel4.Name = "panel4";
            panel4.Size = new Size(1009, 80);
            panel4.TabIndex = 46;
            // 
            // flowLayoutPanelParts
            // 
            flowLayoutPanelParts.AutoScroll = true;
            flowLayoutPanelParts.Location = new Point(0, 54);
            flowLayoutPanelParts.Name = "flowLayoutPanelParts";
            flowLayoutPanelParts.Size = new Size(364, 214);
            flowLayoutPanelParts.TabIndex = 47;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 19);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Поиск необходимых деталей";
            textBox1.Size = new Size(364, 26);
            textBox1.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(flowLayoutPanelParts);
            panel5.Controls.Add(textBox1);
            panel5.Location = new Point(545, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(364, 286);
            panel5.TabIndex = 49;
            // 
            // OrderAddFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxDesc);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(comboBoxStatus);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(comboBoxManufacturer);
            Controls.Add(panel2);
            Controls.Add(comboBoxPrio);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBoxPayment);
            Controls.Add(label8);
            MaximumSize = new Size(1009, 448);
            MinimumSize = new Size(841, 448);
            Name = "OrderAddFrame";
            Size = new Size(1009, 448);
            Load += OrderAddFrame_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
