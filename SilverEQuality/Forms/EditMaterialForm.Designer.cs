namespace SilverEQuality.Forms
{
    partial class EditMaterialForm
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
            label7 = new Label();
            textBoxCode = new TextBox();
            label1 = new Label();
            textBoxTitleSilver = new TextBox();
            label2 = new Label();
            textBoxCost = new TextBox();
            label3 = new Label();
            numericUpDownAmount = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            buttonCancel = new Button();
            buttonDone = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
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
            panelHeader.Size = new Size(442, 30);
            panelHeader.TabIndex = 3;
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
            labelTitle.Text = "Изменение материала";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(373, 0);
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
            buttonExit.Location = new Point(407, 0);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(29, 55);
            label7.Name = "label7";
            label7.Size = new Size(130, 19);
            label7.TabIndex = 20;
            label7.Text = "Код серебра";
            // 
            // textBoxCode
            // 
            textBoxCode.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCode.Location = new Point(182, 52);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(113, 26);
            textBoxCode.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 87);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 22;
            label1.Text = "Наименование";
            // 
            // textBoxTitleSilver
            // 
            textBoxTitleSilver.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitleSilver.Location = new Point(182, 84);
            textBoxTitleSilver.Name = "textBoxTitleSilver";
            textBoxTitleSilver.Size = new Size(231, 26);
            textBoxTitleSilver.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 151);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 24;
            label2.Text = "Стоимость";
            // 
            // textBoxCost
            // 
            textBoxCost.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCost.Location = new Point(182, 148);
            textBoxCost.Name = "textBoxCost";
            textBoxCost.Size = new Size(113, 26);
            textBoxCost.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 119);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 26;
            label3.Text = "Количество";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAmount.Location = new Point(182, 116);
            numericUpDownAmount.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(113, 26);
            numericUpDownAmount.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(305, 119);
            label4.Name = "label4";
            label4.Size = new Size(31, 19);
            label4.TabIndex = 28;
            label4.Text = "кг";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(305, 151);
            label5.Name = "label5";
            label5.Size = new Size(75, 19);
            label5.TabIndex = 29;
            label5.Text = "руб/кг";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCancel);
            panel1.Controls.Add(buttonDone);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 90);
            panel1.TabIndex = 30;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(45, 48);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(362, 33);
            buttonCancel.TabIndex = 3;
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
            buttonDone.Location = new Point(45, 9);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(362, 37);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Добавить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // EditMaterialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 279);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numericUpDownAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCost);
            Controls.Add(label1);
            Controls.Add(textBoxTitleSilver);
            Controls.Add(label7);
            Controls.Add(textBoxCode);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditMaterialForm";
            Text = "EditMaterialForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
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
        private Label label7;
        private TextBox textBoxCode;
        private Label label1;
        private TextBox textBoxTitleSilver;
        private Label label2;
        private TextBox textBoxCost;
        private Label label3;
        private NumericUpDown numericUpDownAmount;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button buttonCancel;
        private Button buttonDone;
    }
}