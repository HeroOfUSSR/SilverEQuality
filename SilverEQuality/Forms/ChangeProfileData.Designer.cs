namespace SilverEQuality.Forms
{
    partial class ChangeProfileData
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
            labelNew = new Label();
            textBoxNew = new TextBox();
            labelCurrent = new Label();
            textBoxCurrent = new TextBox();
            labelRepeat = new Label();
            textBoxRepeat = new TextBox();
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
            panelHeader.Size = new Size(442, 39);
            panelHeader.TabIndex = 4;
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
            labelTitle.Size = new Size(152, 19);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Сменить почту";
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
            buttonExit.Location = new Point(407, 0);
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
            panel1.Location = new Point(0, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 98);
            panel1.TabIndex = 35;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.None;
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(41, 53);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(362, 33);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.None;
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(41, 10);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(362, 37);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Изменить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // labelNew
            // 
            labelNew.Anchor = AnchorStyles.Left;
            labelNew.AutoSize = true;
            labelNew.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNew.Location = new Point(25, 101);
            labelNew.Name = "labelNew";
            labelNew.Size = new Size(130, 19);
            labelNew.TabIndex = 34;
            labelNew.Text = "Новая почта";
            // 
            // textBoxNew
            // 
            textBoxNew.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxNew.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNew.ForeColor = Color.Black;
            textBoxNew.Location = new Point(218, 98);
            textBoxNew.Name = "textBoxNew";
            textBoxNew.Size = new Size(189, 26);
            textBoxNew.TabIndex = 33;
            textBoxNew.Enter += textBoxNew_Enter;
            // 
            // labelCurrent
            // 
            labelCurrent.Anchor = AnchorStyles.Left;
            labelCurrent.AutoSize = true;
            labelCurrent.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrent.ForeColor = Color.Black;
            labelCurrent.Location = new Point(25, 56);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(152, 19);
            labelCurrent.TabIndex = 32;
            labelCurrent.Text = "Текущая почта";
            // 
            // textBoxCurrent
            // 
            textBoxCurrent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxCurrent.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrent.ForeColor = Color.Black;
            textBoxCurrent.Location = new Point(218, 53);
            textBoxCurrent.Name = "textBoxCurrent";
            textBoxCurrent.ReadOnly = true;
            textBoxCurrent.Size = new Size(189, 26);
            textBoxCurrent.TabIndex = 31;
            textBoxCurrent.Enter += textBoxCurrent_Enter;
            // 
            // labelRepeat
            // 
            labelRepeat.Anchor = AnchorStyles.Left;
            labelRepeat.AutoSize = true;
            labelRepeat.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRepeat.Location = new Point(25, 133);
            labelRepeat.Name = "labelRepeat";
            labelRepeat.Size = new Size(174, 19);
            labelRepeat.TabIndex = 37;
            labelRepeat.Text = "Повторите почту";
            // 
            // textBoxRepeat
            // 
            textBoxRepeat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxRepeat.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRepeat.ForeColor = Color.Black;
            textBoxRepeat.Location = new Point(218, 130);
            textBoxRepeat.Name = "textBoxRepeat";
            textBoxRepeat.Size = new Size(189, 26);
            textBoxRepeat.TabIndex = 36;
            textBoxRepeat.Enter += textBoxRepeat_Enter;
            // 
            // ChangeProfileData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 275);
            Controls.Add(labelRepeat);
            Controls.Add(textBoxRepeat);
            Controls.Add(panel1);
            Controls.Add(labelNew);
            Controls.Add(textBoxNew);
            Controls.Add(labelCurrent);
            Controls.Add(textBoxCurrent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(525, 275);
            MinimumSize = new Size(442, 275);
            Name = "ChangeProfileData";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeProfileData";
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
        private Button buttonCancel;
        private Button buttonDone;
        private Label labelNew;
        private TextBox textBoxNew;
        private Label labelCurrent;
        private TextBox textBoxCurrent;
        private Label labelRepeat;
        private TextBox textBoxRepeat;
    }
}