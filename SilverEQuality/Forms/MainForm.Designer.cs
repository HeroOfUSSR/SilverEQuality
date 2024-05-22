namespace SilverEQuality.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            buttonHide = new Button();
            buttonWindowSize = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            buttonChecks = new Button();
            panel4 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            button2 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 56);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonHide);
            panel1.Controls.Add(buttonWindowSize);
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 30);
            panel1.TabIndex = 1;
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(893, 0);
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
            buttonWindowSize.Location = new Point(927, 0);
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
            buttonExit.Location = new Point(958, 0);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(50, 50, 56);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 30);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(218, 420);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonChecks);
            panel2.Location = new Point(3, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 49);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 79);
            panel3.TabIndex = 1;
            // 
            // buttonChecks
            // 
            buttonChecks.BackColor = Color.Transparent;
            buttonChecks.FlatAppearance.BorderSize = 0;
            buttonChecks.FlatStyle = FlatStyle.Flat;
            buttonChecks.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChecks.ForeColor = SystemColors.ControlLightLight;
            buttonChecks.Image = Properties.Resources.report1;
            buttonChecks.ImageAlign = ContentAlignment.MiddleLeft;
            buttonChecks.Location = new Point(-3, 4);
            buttonChecks.Name = "buttonChecks";
            buttonChecks.Size = new Size(211, 41);
            buttonChecks.TabIndex = 1;
            buttonChecks.Text = "Чеки";
            buttonChecks.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Location = new Point(3, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 49);
            panel4.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.report1;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-3, 4);
            button1.Name = "button1";
            button1.Size = new Size(211, 41);
            button1.TabIndex = 1;
            button1.Text = "Чеки";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(3, 198);
            panel5.Name = "panel5";
            panel5.Size = new Size(211, 49);
            panel5.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = Properties.Resources.report1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 4);
            button2.Name = "button2";
            button2.Size = new Size(211, 41);
            button2.TabIndex = 1;
            button2.Text = "Чеки";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 14);
            label3.TabIndex = 5;
            label3.Text = "Главное меню";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHide;
        private Button buttonWindowSize;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonChecks;
        private Panel panel4;
        private Button button1;
        private Panel panel5;
        private Button button2;
        private Label label3;
    }
}