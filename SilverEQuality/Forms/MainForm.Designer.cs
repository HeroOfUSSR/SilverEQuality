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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            label3 = new Label();
            buttonHide = new Button();
            buttonWindowSize = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            slideBar = new FlowLayoutPanel();
            panel5 = new Panel();
            buttonMenu = new Button();
            panel3 = new Panel();
            buttonProfile = new Button();
            panel2 = new Panel();
            buttonChecks = new Button();
            panel4 = new Panel();
            buttonOrders = new Button();
            button1 = new Button();
            panelFrame = new Panel();
            slideBarTimer = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            slideBar.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
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
            panelHeader.Size = new Size(1059, 39);
            panelHeader.TabIndex = 1;
            panelHeader.MouseDown += panelHeader_MouseDown;
            panelHeader.MouseMove += panelHeader_MouseMove;
            panelHeader.MouseUp += panelHeader_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(56, 9);
            label3.Name = "label3";
            label3.Size = new Size(103, 14);
            label3.TabIndex = 5;
            label3.Text = "Главное меню";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(959, 0);
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
            buttonWindowSize.Location = new Point(993, 0);
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
            buttonExit.Location = new Point(1024, 0);
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
            // slideBar
            // 
            slideBar.BackColor = Color.FromArgb(50, 50, 56);
            slideBar.Controls.Add(panel5);
            slideBar.Controls.Add(panel3);
            slideBar.Controls.Add(panel2);
            slideBar.Controls.Add(panel4);
            slideBar.Controls.Add(button1);
            slideBar.Dock = DockStyle.Left;
            slideBar.Location = new Point(0, 39);
            slideBar.MaximumSize = new Size(218, 472);
            slideBar.MinimumSize = new Size(50, 472);
            slideBar.Name = "slideBar";
            slideBar.Size = new Size(218, 472);
            slideBar.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonMenu);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(215, 38);
            panel5.TabIndex = 3;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMenu.ForeColor = SystemColors.ControlLightLight;
            buttonMenu.Image = Properties.Resources.menu;
            buttonMenu.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMenu.Location = new Point(0, -1);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(213, 41);
            buttonMenu.TabIndex = 0;
            buttonMenu.Text = "Меню";
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonProfile);
            panel3.Location = new Point(3, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 55);
            panel3.TabIndex = 1;
            // 
            // buttonProfile
            // 
            buttonProfile.BackColor = Color.Transparent;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProfile.ForeColor = SystemColors.ControlLightLight;
            buttonProfile.Image = Properties.Resources.profile;
            buttonProfile.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProfile.Location = new Point(-3, 3);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Padding = new Padding(3, 0, 0, 0);
            buttonProfile.Size = new Size(211, 49);
            buttonProfile.TabIndex = 1;
            buttonProfile.Text = "Профиль";
            buttonProfile.UseVisualStyleBackColor = false;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonChecks);
            panel2.Location = new Point(3, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(211, 49);
            panel2.TabIndex = 0;
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
            buttonChecks.Location = new Point(2, 5);
            buttonChecks.Name = "buttonChecks";
            buttonChecks.Size = new Size(209, 41);
            buttonChecks.TabIndex = 2;
            buttonChecks.Text = "Чеки";
            buttonChecks.UseVisualStyleBackColor = false;
            buttonChecks.Click += buttonChecks_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonOrders);
            panel4.Location = new Point(3, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 49);
            panel4.TabIndex = 2;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.Transparent;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOrders.ForeColor = SystemColors.ControlLightLight;
            buttonOrders.Image = Properties.Resources.order;
            buttonOrders.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOrders.Location = new Point(0, 4);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(208, 41);
            buttonOrders.TabIndex = 3;
            buttonOrders.Text = "Заказы";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = Properties.Resources.order;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 218);
            button1.Name = "button1";
            button1.Size = new Size(208, 41);
            button1.TabIndex = 4;
            button1.Text = "Заказы";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelFrame
            // 
            panelFrame.Dock = DockStyle.Fill;
            panelFrame.Location = new Point(218, 39);
            panelFrame.Name = "panelFrame";
            panelFrame.Size = new Size(841, 472);
            panelFrame.TabIndex = 3;
            // 
            // slideBarTimer
            // 
            slideBarTimer.Interval = 10;
            slideBarTimer.Tick += slideBarTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 511);
            Controls.Add(panelFrame);
            Controls.Add(slideBar);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            slideBar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonHide;
        private Button buttonWindowSize;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private FlowLayoutPanel slideBar;
        private Panel panel2;
        private Panel panel3;
        private Button buttonChecks;
        private Panel panel4;
        private Button buttonOrders;
        private Label label3;
        private Panel panelFrame;
        private Button buttonProfile;
        private Panel panel5;
        private Button buttonMenu;
        private System.Windows.Forms.Timer slideBarTimer;
        private Button button1;
    }
}