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
            label3 = new Label();
            buttonHide = new Button();
            buttonWindowSize = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button1 = new Button();
            buttonDone = new Button();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerStart = new DateTimePicker();
            checkBoxTodayDate = new CheckBox();
            dateTimePickerEnd = new DateTimePicker();
            comboBox1 = new ComboBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 50, 56);
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(buttonHide);
            panelHeader.Controls.Add(buttonWindowSize);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(56, 11);
            label3.Name = "label3";
            label3.Size = new Size(196, 19);
            label3.TabIndex = 5;
            label3.Text = "Добавление заказа";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(412, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 39);
            buttonHide.TabIndex = 0;
            buttonHide.Text = "_";
            buttonHide.UseVisualStyleBackColor = true;
            // 
            // buttonWindowSize
            // 
            buttonWindowSize.BackgroundImage = Properties.Resources.windowSize;
            buttonWindowSize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonWindowSize.Dock = DockStyle.Right;
            buttonWindowSize.FlatAppearance.BorderSize = 0;
            buttonWindowSize.FlatStyle = FlatStyle.Flat;
            buttonWindowSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonWindowSize.ForeColor = SystemColors.ControlLightLight;
            buttonWindowSize.Location = new Point(446, 0);
            buttonWindowSize.Name = "buttonWindowSize";
            buttonWindowSize.Size = new Size(31, 39);
            buttonWindowSize.TabIndex = 2;
            buttonWindowSize.UseVisualStyleBackColor = true;
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
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonDone);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 373);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 94);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(68, 52);
            button1.Name = "button1";
            button1.Size = new Size(368, 33);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ActiveCaption;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(68, 13);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "button1";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 75);
            label1.Name = "label1";
            label1.Size = new Size(130, 19);
            label1.TabIndex = 5;
            label1.Text = "Дата заказа";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(56, 136);
            label2.Name = "label2";
            label2.Size = new Size(174, 19);
            label2.TabIndex = 7;
            label2.Text = "Дата завершения";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStart.Location = new Point(236, 72);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(200, 26);
            dateTimePickerStart.TabIndex = 8;
            // 
            // checkBoxTodayDate
            // 
            checkBoxTodayDate.AutoSize = true;
            checkBoxTodayDate.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTodayDate.Location = new Point(236, 104);
            checkBoxTodayDate.Name = "checkBoxTodayDate";
            checkBoxTodayDate.Size = new Size(160, 23);
            checkBoxTodayDate.TabIndex = 9;
            checkBoxTodayDate.Text = "Текущая дата";
            checkBoxTodayDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEnd.Location = new Point(236, 133);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(200, 26);
            dateTimePickerEnd.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 27);
            comboBox1.TabIndex = 11;
            // 
            // EditOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 467);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(checkBoxTodayDate);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label label3;
        private Button buttonHide;
        private Button buttonWindowSize;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerStart;
        private CheckBox checkBoxTodayDate;
        private DateTimePicker dateTimePickerEnd;
        private Button button1;
        private Button buttonDone;
        private ComboBox comboBox1;
    }
}