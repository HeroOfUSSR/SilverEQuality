namespace SilverEQuality.Forms
{
    partial class MaterialRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialRequestForm));
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonHide = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            textBoxPayment = new TextBox();
            label6 = new Label();
            comboBoxPrio = new ComboBox();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            panel1 = new Panel();
            panelCaptcha = new Panel();
            buttonCancel = new Button();
            buttonDone = new Button();
            panelAdmin = new Panel();
            dateTimePickerEnd = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            comboBoxSilver = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxDesc = new TextBox();
            numericUpDownAmount = new NumericUpDown();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 50, 56);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(buttonHide);
            panelHeader.Controls.Add(buttonExit);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(661, 30);
            panelHeader.TabIndex = 4;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(37, 8);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(197, 16);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Регистрация запроса";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(592, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 30);
            buttonHide.TabIndex = 4;
            buttonHide.Text = "_";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(626, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 30);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(131, 143);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 29;
            label8.Text = "Примечание \r\nк запросу";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(122, 55);
            label7.Name = "label7";
            label7.Size = new Size(185, 19);
            label7.TabIndex = 27;
            label7.Text = "Стоимость заявки";
            // 
            // textBoxPayment
            // 
            textBoxPayment.Anchor = AnchorStyles.Top;
            textBoxPayment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPayment.Location = new Point(319, 52);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(200, 26);
            textBoxPayment.TabIndex = 26;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(326, 18);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 25;
            label6.Text = "Приоритет";
            // 
            // comboBoxPrio
            // 
            comboBoxPrio.Anchor = AnchorStyles.Top;
            comboBoxPrio.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPrio.FormattingEnabled = true;
            comboBoxPrio.Location = new Point(440, 15);
            comboBoxPrio.Name = "comboBoxPrio";
            comboBoxPrio.Size = new Size(200, 27);
            comboBoxPrio.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(23, 18);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 23;
            label5.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Anchor = AnchorStyles.Top;
            comboBoxStatus.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(107, 15);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 27);
            comboBoxStatus.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelCaptcha);
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonDone);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 102);
            panel1.TabIndex = 21;
            // 
            // panelCaptcha
            // 
            panelCaptcha.Dock = DockStyle.Top;
            panelCaptcha.Location = new Point(0, 0);
            panelCaptcha.Name = "panelCaptcha";
            panelCaptcha.Size = new Size(661, 10);
            panelCaptcha.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top;
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(151, 59);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(368, 33);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top;
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(151, 16);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Создать";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(dateTimePickerEnd);
            panelAdmin.Controls.Add(label4);
            panelAdmin.Controls.Add(comboBoxStatus);
            panelAdmin.Controls.Add(label5);
            panelAdmin.Controls.Add(comboBoxPrio);
            panelAdmin.Controls.Add(label6);
            panelAdmin.Controls.Add(textBoxPayment);
            panelAdmin.Controls.Add(label7);
            panelAdmin.Dock = DockStyle.Bottom;
            panelAdmin.Location = new Point(0, 239);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(661, 120);
            panelAdmin.TabIndex = 31;
            panelAdmin.Visible = false;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(319, 84);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 26);
            dateTimePickerEnd.TabIndex = 29;
            dateTimePickerEnd.Value = new DateTime(2024, 6, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(133, 87);
            label4.Name = "label4";
            label4.Size = new Size(174, 19);
            label4.TabIndex = 28;
            label4.Text = "Дата завершения";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 99);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 32;
            label1.Text = "Количество*";
            // 
            // comboBoxSilver
            // 
            comboBoxSilver.Anchor = AnchorStyles.Top;
            comboBoxSilver.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxSilver.FormattingEnabled = true;
            comboBoxSilver.Location = new Point(271, 55);
            comboBoxSilver.Name = "comboBoxSilver";
            comboBoxSilver.Size = new Size(261, 27);
            comboBoxSilver.TabIndex = 33;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 58);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 34;
            label2.Text = "Тип серебра*";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(403, 99);
            label3.Name = "label3";
            label3.Size = new Size(31, 19);
            label3.TabIndex = 35;
            label3.Text = "кг";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Anchor = AnchorStyles.Top;
            textBoxDesc.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(271, 140);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(261, 82);
            textBoxDesc.TabIndex = 28;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Anchor = AnchorStyles.Top;
            numericUpDownAmount.DecimalPlaces = 3;
            numericUpDownAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(271, 97);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 26);
            numericUpDownAmount.TabIndex = 37;
            // 
            // MaterialRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 461);
            Controls.Add(numericUpDownAmount);
            Controls.Add(label3);
            Controls.Add(comboBoxSilver);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelAdmin);
            Controls.Add(label8);
            Controls.Add(textBoxDesc);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MaterialRequestForm";
            Text = "MaterialRequestForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonHide;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private TextBox textBoxPayment;
        private Label label6;
        private ComboBox comboBoxPrio;
        private Label label5;
        private ComboBox comboBoxStatus;
        private Panel panel1;
        private Button buttonCancel;
        private Button buttonDone;
        private Panel panelAdmin;
        private Label label1;
        private ComboBox comboBoxSilver;
        private Label label2;
        private Panel panelCaptcha;
        private Label label3;
        private TextBox textBoxDesc;
        private DateTimePicker dateTimePickerEnd;
        private Label label4;
        private NumericUpDown numericUpDownAmount;
    }
}