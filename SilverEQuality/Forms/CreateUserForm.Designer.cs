namespace SilverEQuality.Forms
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonHide = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            textBoxFullname = new TextBox();
            comboBoxRoles = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            dateTimePickerBirth = new DateTimePicker();
            label4 = new Label();
            textBoxPhone = new TextBox();
            label6 = new Label();
            textBoxMail = new TextBox();
            comboBoxDepartment = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            textBoxPassword = new TextBox();
            label10 = new Label();
            textBoxLogin = new TextBox();
            panelPhoto = new Panel();
            buttonChangeAv = new Button();
            pictureBoxAvatar = new PictureBox();
            checkBoxAvailable = new CheckBox();
            panel2 = new Panel();
            buttonCancel = new Button();
            buttonDone = new Button();
            openFileDialogChangeAv = new OpenFileDialog();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            panel2.SuspendLayout();
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
            panelHeader.Size = new Size(542, 39);
            panelHeader.TabIndex = 5;
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
            labelTitle.Size = new Size(229, 19);
            labelTitle.TabIndex = 5;
            labelTitle.Text = "Создать пользователя";
            // 
            // buttonHide
            // 
            buttonHide.Dock = DockStyle.Right;
            buttonHide.FlatAppearance.BorderSize = 0;
            buttonHide.FlatStyle = FlatStyle.Flat;
            buttonHide.Font = new Font("Lucida Console", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHide.ForeColor = SystemColors.ControlLightLight;
            buttonHide.Location = new Point(473, 0);
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
            buttonExit.Location = new Point(507, 0);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(67, 69);
            label7.Name = "label7";
            label7.Size = new Size(53, 19);
            label7.TabIndex = 24;
            label7.Text = "ФИО*";
            // 
            // textBoxFullname
            // 
            textBoxFullname.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFullname.Location = new Point(252, 66);
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.Size = new Size(231, 26);
            textBoxFullname.TabIndex = 1;
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.Anchor = AnchorStyles.Top;
            comboBoxRoles.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(252, 196);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(231, 27);
            comboBoxRoles.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 199);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 28;
            label5.Text = "Должность*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 232);
            label3.Name = "label3";
            label3.Size = new Size(163, 19);
            label3.TabIndex = 32;
            label3.Text = "Дата рождения*";
            // 
            // dateTimePickerBirth
            // 
            dateTimePickerBirth.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBirth.Location = new Point(252, 229);
            dateTimePickerBirth.Name = "dateTimePickerBirth";
            dateTimePickerBirth.Size = new Size(231, 26);
            dateTimePickerBirth.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 102);
            label4.Name = "label4";
            label4.Size = new Size(174, 19);
            label4.TabIndex = 35;
            label4.Text = "Номер телефона*";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(252, 99);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(231, 26);
            textBoxPhone.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 134);
            label6.Name = "label6";
            label6.Size = new Size(64, 19);
            label6.TabIndex = 37;
            label6.Text = "Почта";
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(252, 131);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(231, 26);
            textBoxMail.TabIndex = 5;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.Anchor = AnchorStyles.Top;
            comboBoxDepartment.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new Point(252, 163);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(231, 27);
            comboBoxDepartment.TabIndex = 6;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(67, 166);
            label8.Name = "label8";
            label8.Size = new Size(130, 19);
            label8.TabIndex = 39;
            label8.Text = "Номер цеха*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(111, 308);
            label9.Name = "label9";
            label9.Size = new Size(75, 19);
            label9.TabIndex = 43;
            label9.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(202, 305);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(231, 26);
            textBoxPassword.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(122, 276);
            label10.Name = "label10";
            label10.Size = new Size(64, 19);
            label10.TabIndex = 42;
            label10.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(202, 273);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(231, 26);
            textBoxLogin.TabIndex = 9;
            // 
            // panelPhoto
            // 
            panelPhoto.Controls.Add(buttonChangeAv);
            panelPhoto.Controls.Add(pictureBoxAvatar);
            panelPhoto.Location = new Point(67, 346);
            panelPhoto.Name = "panelPhoto";
            panelPhoto.Size = new Size(400, 107);
            panelPhoto.TabIndex = 44;
            // 
            // buttonChangeAv
            // 
            buttonChangeAv.BackColor = Color.SteelBlue;
            buttonChangeAv.FlatAppearance.BorderSize = 0;
            buttonChangeAv.FlatStyle = FlatStyle.Flat;
            buttonChangeAv.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeAv.ForeColor = SystemColors.ControlLightLight;
            buttonChangeAv.Location = new Point(148, 75);
            buttonChangeAv.Name = "buttonChangeAv";
            buttonChangeAv.Size = new Size(207, 25);
            buttonChangeAv.TabIndex = 11;
            buttonChangeAv.Text = "Изменить фото";
            buttonChangeAv.UseVisualStyleBackColor = false;
            buttonChangeAv.Click += buttonChangeAv_Click;
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.profileMain;
            pictureBoxAvatar.Location = new Point(44, 3);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(98, 97);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar.TabIndex = 5;
            pictureBoxAvatar.TabStop = false;
            // 
            // checkBoxAvailable
            // 
            checkBoxAvailable.AutoSize = true;
            checkBoxAvailable.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxAvailable.Checked = true;
            checkBoxAvailable.CheckState = CheckState.Checked;
            checkBoxAvailable.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAvailable.Location = new Point(133, 459);
            checkBoxAvailable.Name = "checkBoxAvailable";
            checkBoxAvailable.Size = new Size(259, 23);
            checkBoxAvailable.TabIndex = 12;
            checkBoxAvailable.Text = "Пользователен активен";
            checkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonCancel);
            panel2.Controls.Add(buttonDone);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 86);
            panel2.TabIndex = 14;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.AppWorkspace;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(79, 47);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(368, 33);
            buttonCancel.TabIndex = 14;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.SteelBlue;
            buttonDone.FlatAppearance.BorderSize = 0;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDone.ForeColor = SystemColors.ControlLightLight;
            buttonDone.Location = new Point(79, 8);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(368, 37);
            buttonDone.TabIndex = 13;
            buttonDone.Text = "Создать";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // openFileDialogChangeAv
            // 
            openFileDialogChangeAv.FileName = "openFileDialog1";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 574);
            Controls.Add(panel2);
            Controls.Add(checkBoxAvailable);
            Controls.Add(panelPhoto);
            Controls.Add(label9);
            Controls.Add(textBoxPassword);
            Controls.Add(label10);
            Controls.Add(textBoxLogin);
            Controls.Add(comboBoxDepartment);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(textBoxMail);
            Controls.Add(label4);
            Controls.Add(textBoxPhone);
            Controls.Add(dateTimePickerBirth);
            Controls.Add(label3);
            Controls.Add(comboBoxRoles);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(textBoxFullname);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateUserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateUserForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonHide;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBoxName;
        private Label label7;
        private TextBox textBoxFullname;
        private ComboBox comboBoxRoles;
        private Label label5;
        private Label label2;
        private TextBox textBoxPatronimyc;
        private Label label3;
        private DateTimePicker dateTimePickerBirth;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label6;
        private TextBox textBoxMail;
        private ComboBox comboBoxDepartment;
        private Label label8;
        private Label label9;
        private TextBox textBoxPassword;
        private Label label10;
        private TextBox textBoxLogin;
        private Panel panelPhoto;
        private Button buttonChangeAv;
        private PictureBox pictureBoxAvatar;
        private CheckBox checkBoxAvailable;
        private Panel panel2;
        private Button buttonCancel;
        private Button buttonDone;
        private OpenFileDialog openFileDialogChangeAv;
    }
}