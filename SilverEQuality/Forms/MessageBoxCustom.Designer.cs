namespace SilverEQuality.MessageBoxes
{
    partial class MessageBoxCustom
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
            buttonOK = new Button();
            labelErrorMes = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panelHeader.Size = new Size(419, 30);
            panelHeader.TabIndex = 2;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(37, 8);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 5;
            label3.Text = "Внимание";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(319, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 30);
            buttonHide.TabIndex = 4;
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
            buttonWindowSize.Location = new Point(353, 0);
            buttonWindowSize.Name = "buttonWindowSize";
            buttonWindowSize.Size = new Size(31, 30);
            buttonWindowSize.TabIndex = 3;
            buttonWindowSize.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(384, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 30);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
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
            // buttonOK
            // 
            buttonOK.BackColor = SystemColors.ActiveCaption;
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.ForeColor = SystemColors.ControlLightLight;
            buttonOK.Location = new Point(69, 112);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(275, 32);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // labelErrorMes
            // 
            labelErrorMes.Anchor = AnchorStyles.None;
            labelErrorMes.AutoSize = true;
            labelErrorMes.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorMes.Location = new Point(37, 63);
            labelErrorMes.Name = "labelErrorMes";
            labelErrorMes.Size = new Size(86, 19);
            labelErrorMes.TabIndex = 4;
            labelErrorMes.Text = "Ошибка!";
            // 
            // MessageBoxCustom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 156);
            Controls.Add(labelErrorMes);
            Controls.Add(buttonOK);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MessageBoxCustom";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MessageBoxAuth";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button buttonOK;
        private Label labelErrorMes;
    }
}