namespace SilverEQuality.FramesUC
{
    partial class ProfileFrame
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonCreateUser = new Button();
            buttonChangeAv = new Button();
            buttonPassword = new Button();
            buttonEmail = new Button();
            labelDate = new Label();
            labelName = new Label();
            pictureBoxAvatar = new PictureBox();
            panel3 = new Panel();
            buttonUsers = new Button();
            buttonComment = new Button();
            buttonOrders = new Button();
            panel2 = new Panel();
            openFileDialogChangeAv = new OpenFileDialog();
            panelBody = new Panel();
            flowLayoutPanelBody = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            panel3.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCreateUser);
            panel1.Controls.Add(buttonChangeAv);
            panel1.Controls.Add(buttonPassword);
            panel1.Controls.Add(buttonEmail);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(pictureBoxAvatar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 132);
            panel1.TabIndex = 0;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Anchor = AnchorStyles.Right;
            buttonCreateUser.BackColor = Color.SteelBlue;
            buttonCreateUser.FlatAppearance.BorderSize = 0;
            buttonCreateUser.FlatStyle = FlatStyle.Flat;
            buttonCreateUser.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateUser.ForeColor = SystemColors.ControlLightLight;
            buttonCreateUser.Location = new Point(720, 74);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(261, 24);
            buttonCreateUser.TabIndex = 9;
            buttonCreateUser.Text = "Создать юзера";
            buttonCreateUser.UseVisualStyleBackColor = false;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // buttonChangeAv
            // 
            buttonChangeAv.BackColor = Color.SteelBlue;
            buttonChangeAv.FlatAppearance.BorderSize = 0;
            buttonChangeAv.FlatStyle = FlatStyle.Flat;
            buttonChangeAv.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeAv.ForeColor = SystemColors.ControlLightLight;
            buttonChangeAv.Location = new Point(115, 77);
            buttonChangeAv.Name = "buttonChangeAv";
            buttonChangeAv.Size = new Size(207, 25);
            buttonChangeAv.TabIndex = 4;
            buttonChangeAv.Text = "Изменить фото";
            buttonChangeAv.UseVisualStyleBackColor = false;
            buttonChangeAv.Click += buttonChangeAv_Click;
            // 
            // buttonPassword
            // 
            buttonPassword.Anchor = AnchorStyles.Right;
            buttonPassword.BackColor = Color.SteelBlue;
            buttonPassword.FlatAppearance.BorderSize = 0;
            buttonPassword.FlatStyle = FlatStyle.Flat;
            buttonPassword.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPassword.ForeColor = SystemColors.ControlLightLight;
            buttonPassword.Location = new Point(720, 44);
            buttonPassword.Name = "buttonPassword";
            buttonPassword.Size = new Size(261, 24);
            buttonPassword.TabIndex = 8;
            buttonPassword.Text = "Сменить пароль";
            buttonPassword.UseVisualStyleBackColor = false;
            buttonPassword.Click += buttonPassword_Click;
            // 
            // buttonEmail
            // 
            buttonEmail.Anchor = AnchorStyles.Right;
            buttonEmail.BackColor = Color.SteelBlue;
            buttonEmail.FlatAppearance.BorderSize = 0;
            buttonEmail.FlatStyle = FlatStyle.Flat;
            buttonEmail.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEmail.ForeColor = SystemColors.ControlLightLight;
            buttonEmail.Location = new Point(720, 14);
            buttonEmail.Name = "buttonEmail";
            buttonEmail.Size = new Size(261, 24);
            buttonEmail.TabIndex = 7;
            buttonEmail.Text = "Указать почту";
            buttonEmail.UseVisualStyleBackColor = false;
            buttonEmail.Click += buttonEmail_Click;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(115, 40);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(137, 16);
            labelDate.TabIndex = 3;
            labelDate.Text = "Дата рождения";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(115, 14);
            labelName.Name = "labelName";
            labelName.Size = new Size(207, 16);
            labelName.TabIndex = 2;
            labelName.Text = "Фамилия Имя Отчество";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.profileMain;
            pictureBoxAvatar.Location = new Point(11, 5);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(98, 97);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 1;
            pictureBoxAvatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonUsers);
            panel3.Controls.Add(buttonComment);
            panel3.Controls.Add(buttonOrders);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 24);
            panel3.TabIndex = 0;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.SteelBlue;
            buttonUsers.Dock = DockStyle.Left;
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsers.ForeColor = SystemColors.ControlLightLight;
            buttonUsers.Location = new Point(342, 0);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(171, 24);
            buttonUsers.TabIndex = 7;
            buttonUsers.Text = "Пользователи";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonComment
            // 
            buttonComment.BackColor = Color.SteelBlue;
            buttonComment.Dock = DockStyle.Left;
            buttonComment.FlatAppearance.BorderSize = 0;
            buttonComment.FlatStyle = FlatStyle.Flat;
            buttonComment.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComment.ForeColor = SystemColors.ControlLightLight;
            buttonComment.Location = new Point(171, 0);
            buttonComment.Name = "buttonComment";
            buttonComment.Size = new Size(171, 24);
            buttonComment.TabIndex = 6;
            buttonComment.Text = "Комментарии";
            buttonComment.UseVisualStyleBackColor = false;
            buttonComment.Click += buttonComment_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.SteelBlue;
            buttonOrders.Dock = DockStyle.Left;
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOrders.ForeColor = SystemColors.ControlLightLight;
            buttonOrders.Location = new Point(0, 0);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(171, 24);
            buttonOrders.TabIndex = 5;
            buttonOrders.Text = "Заказы";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(1009, 22);
            panel2.TabIndex = 1;
            // 
            // openFileDialogChangeAv
            // 
            openFileDialogChangeAv.FileName = "openFileDialog1";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(flowLayoutPanelBody);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 132);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1009, 318);
            panelBody.TabIndex = 2;
            // 
            // flowLayoutPanelBody
            // 
            flowLayoutPanelBody.Anchor = AnchorStyles.None;
            flowLayoutPanelBody.AutoScroll = true;
            flowLayoutPanelBody.Location = new Point(83, 0);
            flowLayoutPanelBody.Name = "flowLayoutPanelBody";
            flowLayoutPanelBody.Size = new Size(840, 318);
            flowLayoutPanelBody.TabIndex = 0;
            // 
            // ProfileFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(1009, 472);
            MinimumSize = new Size(841, 472);
            Name = "ProfileFrame";
            Size = new Size(1009, 472);
            Resize += ProfileFrame_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            panel3.ResumeLayout(false);
            panelBody.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBoxAvatar;
        private Label labelName;
        private Label labelDate;
        private Button buttonChangeAv;
        private OpenFileDialog openFileDialogChangeAv;
        private Button buttonOrders;
        private Button buttonComment;
        private Panel panelBody;
        private FlowLayoutPanel flowLayoutPanelBody;
        private Button buttonEmail;
        private Button buttonPassword;
        private Button buttonCreateUser;
        private Button buttonUsers;
    }
}
