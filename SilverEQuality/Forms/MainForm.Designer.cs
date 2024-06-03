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
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            slideBar = new FlowLayoutPanel();
            panelMenu = new Panel();
            buttonMenu = new Button();
            panelProfile = new Panel();
            buttonProfile = new Button();
            panelChecks = new Panel();
            buttonChecks = new Button();
            panelOrders = new Panel();
            buttonOrders = new Button();
            panelNorms = new Panel();
            buttonNorms = new Button();
            panel1 = new Panel();
            buttonMaterials = new Button();
            panelLogout = new Panel();
            buttonLogout = new Button();
            panelFrame = new Panel();
            slideBarTimer = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            slideBar.SuspendLayout();
            panelMenu.SuspendLayout();
            panelProfile.SuspendLayout();
            panelChecks.SuspendLayout();
            panelOrders.SuspendLayout();
            panelNorms.SuspendLayout();
            panel1.SuspendLayout();
            panelLogout.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(50, 50, 56);
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(buttonHide);
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
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(56, 11);
            label3.Name = "label3";
            label3.Size = new Size(141, 19);
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
            buttonHide.Location = new Point(990, 0);
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
            buttonExit.Location = new Point(1024, 0);
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
            // slideBar
            // 
            slideBar.BackColor = Color.FromArgb(50, 50, 56);
            slideBar.Controls.Add(panelMenu);
            slideBar.Controls.Add(panelProfile);
            slideBar.Controls.Add(panelChecks);
            slideBar.Controls.Add(panelOrders);
            slideBar.Controls.Add(panelNorms);
            slideBar.Controls.Add(panel1);
            slideBar.Controls.Add(panelLogout);
            slideBar.Dock = DockStyle.Left;
            slideBar.Location = new Point(0, 39);
            slideBar.MaximumSize = new Size(218, 472);
            slideBar.MinimumSize = new Size(50, 472);
            slideBar.Name = "slideBar";
            slideBar.Size = new Size(218, 472);
            slideBar.TabIndex = 0;
            slideBar.Resize += slideBar_Resize;
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(buttonMenu);
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(215, 38);
            panelMenu.TabIndex = 3;
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
            // panelProfile
            // 
            panelProfile.Controls.Add(buttonProfile);
            panelProfile.Location = new Point(3, 47);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(211, 55);
            panelProfile.TabIndex = 1;
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
            // panelChecks
            // 
            panelChecks.Controls.Add(buttonChecks);
            panelChecks.Location = new Point(3, 108);
            panelChecks.Name = "panelChecks";
            panelChecks.Size = new Size(211, 49);
            panelChecks.TabIndex = 0;
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
            // panelOrders
            // 
            panelOrders.Controls.Add(buttonOrders);
            panelOrders.Location = new Point(3, 163);
            panelOrders.Name = "panelOrders";
            panelOrders.Size = new Size(211, 49);
            panelOrders.TabIndex = 2;
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
            // panelNorms
            // 
            panelNorms.Controls.Add(buttonNorms);
            panelNorms.Location = new Point(3, 218);
            panelNorms.Name = "panelNorms";
            panelNorms.Size = new Size(211, 49);
            panelNorms.TabIndex = 5;
            // 
            // buttonNorms
            // 
            buttonNorms.BackColor = Color.Transparent;
            buttonNorms.FlatAppearance.BorderSize = 0;
            buttonNorms.FlatStyle = FlatStyle.Flat;
            buttonNorms.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNorms.ForeColor = SystemColors.ControlLightLight;
            buttonNorms.Image = Properties.Resources.norm;
            buttonNorms.ImageAlign = ContentAlignment.MiddleLeft;
            buttonNorms.Location = new Point(1, 4);
            buttonNorms.Name = "buttonNorms";
            buttonNorms.Size = new Size(208, 41);
            buttonNorms.TabIndex = 5;
            buttonNorms.Text = "Нормы";
            buttonNorms.UseVisualStyleBackColor = false;
            buttonNorms.Click += buttonNorms_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonMaterials);
            panel1.Location = new Point(3, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 49);
            panel1.TabIndex = 6;
            // 
            // buttonMaterials
            // 
            buttonMaterials.BackColor = Color.Transparent;
            buttonMaterials.FlatAppearance.BorderSize = 0;
            buttonMaterials.FlatStyle = FlatStyle.Flat;
            buttonMaterials.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMaterials.ForeColor = SystemColors.ControlLightLight;
            buttonMaterials.Image = Properties.Resources.silver;
            buttonMaterials.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMaterials.Location = new Point(1, 4);
            buttonMaterials.Name = "buttonMaterials";
            buttonMaterials.Size = new Size(208, 41);
            buttonMaterials.TabIndex = 5;
            buttonMaterials.Text = "Материалы";
            buttonMaterials.UseVisualStyleBackColor = false;
            buttonMaterials.Click += buttonMaterials_Click;
            // 
            // panelLogout
            // 
            panelLogout.Controls.Add(buttonLogout);
            panelLogout.Location = new Point(3, 328);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(211, 49);
            panelLogout.TabIndex = 8;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Transparent;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogout.ForeColor = SystemColors.ControlLightLight;
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(1, 4);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(208, 41);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Выйти";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelFrame
            // 
            panelFrame.BackColor = Color.White;
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
            Text = " ";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            slideBar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelProfile.ResumeLayout(false);
            panelChecks.ResumeLayout(false);
            panelOrders.ResumeLayout(false);
            panelNorms.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Button buttonHide;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private FlowLayoutPanel slideBar;
        private Panel panelChecks;
        private Panel panelProfile;
        private Button buttonChecks;
        private Panel panelOrders;
        private Button buttonOrders;
        private Label label3;
        private Panel panelFrame;
        private Button buttonProfile;
        private Panel panelMenu;
        private Button buttonMenu;
        private System.Windows.Forms.Timer slideBarTimer;
        private Panel panelNorms;
        private Button buttonNorms;
        private Panel panel1;
        private Button buttonMaterials;
        private Panel panelLogout;
        private Button buttonLogout;
    }
}