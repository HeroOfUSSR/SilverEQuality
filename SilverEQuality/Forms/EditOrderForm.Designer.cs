namespace SilverEQuality.Forms
{
    partial class EditOrderForm
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
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonHide = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonDone = new Button();
            label2 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            label5 = new Label();
            comboBoxStatus = new ComboBox();
            label6 = new Label();
            comboBoxPrio = new ComboBox();
            textBoxPayment = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxDesc = new TextBox();
            label3 = new Label();
            comboBoxAppointed = new ComboBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            panelHeader.Size = new Size(512, 39);
            panelHeader.TabIndex = 2;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.ForeColor = SystemColors.ControlLightLight;
            labelTitle.Location = new Point(56, 11);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(240, 19);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Редактирование заказа";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(443, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 39);
            buttonHide.TabIndex = 0;
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
            buttonExit.Location = new Point(477, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 39);
            buttonExit.TabIndex = 1;
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
            pictureBox1.Padding = new Padding(8, 5, 10, 5);
            pictureBox1.Size = new Size(50, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonDone);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 340);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 94);
            panel1.TabIndex = 3;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(68, 52);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(368, 33);
            buttonCancel.TabIndex = 1;
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
            buttonDone.Location = new Point(68, 13);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Изменить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 296);
            label2.Name = "label2";
            label2.Size = new Size(174, 19);
            label2.TabIndex = 7;
            label2.Text = "Дата завершения";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(236, 296);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 26);
            dateTimePickerEnd.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 92);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 14;
            label5.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(236, 92);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(200, 27);
            comboBoxStatus.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 125);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 16;
            label6.Text = "Приоритет";
            // 
            // comboBoxPrio
            // 
            comboBoxPrio.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxPrio.FormattingEnabled = true;
            comboBoxPrio.Location = new Point(236, 125);
            comboBoxPrio.Name = "comboBoxPrio";
            comboBoxPrio.Size = new Size(200, 27);
            comboBoxPrio.TabIndex = 15;
            // 
            // textBoxPayment
            // 
            textBoxPayment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPayment.Location = new Point(236, 264);
            textBoxPayment.Name = "textBoxPayment";
            textBoxPayment.Size = new Size(200, 26);
            textBoxPayment.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(41, 264);
            label7.Name = "label7";
            label7.Size = new Size(163, 19);
            label7.TabIndex = 18;
            label7.Text = "Плата за заказ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(41, 158);
            label8.Name = "label8";
            label8.Size = new Size(97, 19);
            label8.TabIndex = 20;
            label8.Text = "Описание";
            // 
            // textBoxDesc
            // 
            textBoxDesc.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDesc.Location = new Point(236, 158);
            textBoxDesc.Multiline = true;
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(200, 82);
            textBoxDesc.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 55);
            label3.Name = "label3";
            label3.Size = new Size(152, 19);
            label3.TabIndex = 22;
            label3.Text = "Ответственный";
            // 
            // comboBoxAppointed
            // 
            comboBoxAppointed.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAppointed.FormattingEnabled = true;
            comboBoxAppointed.Location = new Point(236, 55);
            comboBoxAppointed.Name = "comboBoxAppointed";
            comboBoxAppointed.Size = new Size(200, 27);
            comboBoxAppointed.TabIndex = 21;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 434);
            Controls.Add(label3);
            Controls.Add(comboBoxAppointed);
            Controls.Add(label8);
            Controls.Add(textBoxDesc);
            Controls.Add(label7);
            Controls.Add(textBoxPayment);
            Controls.Add(label6);
            Controls.Add(comboBoxPrio);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditForm";
            Load += EditOrderForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonHide;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonCancel;
        private Button buttonDone;
        private Label label5;
        private ComboBox comboBoxStatus;
        private Label label6;
        private ComboBox comboBoxPrio;
        private TextBox textBoxPayment;
        private Label label7;
        private Label label8;
        private TextBox textBoxDesc;
        private Label label3;
        private ComboBox comboBoxAppointed;
    }
}