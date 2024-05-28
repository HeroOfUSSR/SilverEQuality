namespace SilverEQuality
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            buttonHide = new Button();
            buttonWindowSize = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            buttonCancel = new Button();
            buttonLogin = new Button();
            panel4 = new Panel();
            buttonReload = new Button();
            textBoxCaptcha = new TextBox();
            panelCaptcha = new Panel();
            label2 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(440, 30);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(39, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 14);
            label3.TabIndex = 4;
            label3.Text = "Авторизация";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(340, 0);
            buttonHide.Name = "buttonHide";
            buttonHide.Size = new Size(34, 30);
            buttonHide.TabIndex = 6;
            buttonHide.Text = "_";
            buttonHide.UseVisualStyleBackColor = true;
            buttonHide.Click += buttonHide_Click;
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
            buttonWindowSize.Location = new Point(374, 0);
            buttonWindowSize.Name = "buttonWindowSize";
            buttonWindowSize.Size = new Size(31, 30);
            buttonWindowSize.TabIndex = 7;
            buttonWindowSize.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ControlLightLight;
            buttonExit.Location = new Point(405, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(35, 30);
            buttonExit.TabIndex = 8;
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
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 87);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.logoMain;
            pictureBox2.Location = new Point(0, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(5, 0, 5, 0);
            pictureBox2.Size = new Size(440, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonCancel);
            panel3.Controls.Add(buttonLogin);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 94);
            panel3.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ActiveBorder;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(65, 55);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(320, 27);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Выйти";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.SteelBlue;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.ControlLightLight;
            buttonLogin.Location = new Point(65, 15);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(320, 36);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Авторизоваться";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonReload);
            panel4.Controls.Add(textBoxCaptcha);
            panel4.Controls.Add(panelCaptcha);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBoxPassword);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(textBoxLogin);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(440, 133);
            panel4.TabIndex = 0;
            // 
            // buttonReload
            // 
            buttonReload.BackgroundImage = Properties.Resources.refresh;
            buttonReload.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReload.FlatAppearance.BorderSize = 0;
            buttonReload.FlatStyle = FlatStyle.Flat;
            buttonReload.Location = new Point(324, 275);
            buttonReload.Name = "buttonReload";
            buttonReload.Size = new Size(31, 26);
            buttonReload.TabIndex = 4;
            buttonReload.UseVisualStyleBackColor = true;
            buttonReload.Visible = false;
            buttonReload.Click += buttonReload_Click;
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCaptcha.Location = new Point(86, 275);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(232, 26);
            textBoxCaptcha.TabIndex = 2;
            textBoxCaptcha.Visible = false;
            // 
            // panelCaptcha
            // 
            panelCaptcha.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            panelCaptcha.Location = new Point(73, 135);
            panelCaptcha.Name = "panelCaptcha";
            panelCaptcha.Size = new Size(300, 134);
            panelCaptcha.TabIndex = 4;
            panelCaptcha.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 94);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(176, 91);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(198, 26);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 19);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(176, 45);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(198, 26);
            textBoxLogin.TabIndex = 0;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 344);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(440, 520);
            MinimumSize = new Size(440, 344);
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHide;
        private Button buttonWindowSize;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private TextBox textBoxLogin;
        private Label label2;
        private TextBox textBoxPassword;
        private Button buttonCancel;
        private Button buttonLogin;
        private Label label3;
        private Panel panelCaptcha;
        private Button buttonReload;
        private TextBox textBoxCaptcha;
    }
}
