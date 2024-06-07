namespace SilverEQuality.FramesUC
{
    partial class UserView
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
            labelDateBirth = new Label();
            panel2 = new Panel();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panel1 = new Panel();
            pictureBoxAuthor = new PictureBox();
            textBoxMail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxFullname = new TextBox();
            labelRole = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor).BeginInit();
            SuspendLayout();
            // 
            // labelDateBirth
            // 
            labelDateBirth.AutoSize = true;
            labelDateBirth.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateBirth.Location = new Point(157, 109);
            labelDateBirth.Name = "labelDateBirth";
            labelDateBirth.Size = new Size(127, 16);
            labelDateBirth.TabIndex = 9;
            labelDateBirth.Text = "25 июня 2023";
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonEdit);
            panel2.Controls.Add(buttonDelete);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(650, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 134);
            panel2.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.Dock = DockStyle.Bottom;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(0, 70);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(150, 32);
            buttonEdit.TabIndex = 32;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.RosyBrown;
            buttonDelete.DialogResult = DialogResult.OK;
            buttonDelete.Dock = DockStyle.Bottom;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ControlLightLight;
            buttonDelete.Location = new Point(0, 102);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 32);
            buttonDelete.TabIndex = 33;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxAuthor);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 134);
            panel1.TabIndex = 5;
            // 
            // pictureBoxAuthor
            // 
            pictureBoxAuthor.Dock = DockStyle.Top;
            pictureBoxAuthor.Image = Properties.Resources.profileMain;
            pictureBoxAuthor.Location = new Point(0, 0);
            pictureBoxAuthor.Margin = new Padding(10);
            pictureBoxAuthor.Name = "pictureBoxAuthor";
            pictureBoxAuthor.Padding = new Padding(15, 10, 15, 10);
            pictureBoxAuthor.Size = new Size(153, 134);
            pictureBoxAuthor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAuthor.TabIndex = 0;
            pictureBoxAuthor.TabStop = false;
            // 
            // textBoxMail
            // 
            textBoxMail.BackColor = Color.White;
            textBoxMail.BorderStyle = BorderStyle.None;
            textBoxMail.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(166, 50);
            textBoxMail.Multiline = true;
            textBoxMail.Name = "textBoxMail";
            textBoxMail.ReadOnly = true;
            textBoxMail.Size = new Size(478, 23);
            textBoxMail.TabIndex = 8;
            textBoxMail.Text = "alexey_ivanov04@mail.ru";
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.White;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(166, 79);
            textBoxPhone.Multiline = true;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.ReadOnly = true;
            textBoxPhone.Size = new Size(478, 23);
            textBoxPhone.TabIndex = 11;
            textBoxPhone.Text = "89819748691";
            // 
            // textBoxFullname
            // 
            textBoxFullname.BackColor = Color.White;
            textBoxFullname.BorderStyle = BorderStyle.None;
            textBoxFullname.Font = new Font("Lucida Console", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFullname.Location = new Point(166, 8);
            textBoxFullname.Multiline = true;
            textBoxFullname.Name = "textBoxFullname";
            textBoxFullname.ReadOnly = true;
            textBoxFullname.Size = new Size(478, 36);
            textBoxFullname.TabIndex = 12;
            textBoxFullname.Text = "Иванов Алексей Анатольевич\r\n";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRole.Location = new Point(479, 109);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(137, 16);
            labelRole.TabIndex = 13;
            labelRole.Text = "Администратор";
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelRole);
            Controls.Add(textBoxFullname);
            Controls.Add(textBoxPhone);
            Controls.Add(labelDateBirth);
            Controls.Add(textBoxMail);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserView";
            Size = new Size(800, 134);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAuthor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDateBirth;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBoxAuthor;
        private TextBox textBoxMail;
        private TextBox textBoxPhone;
        private TextBox textBoxFullname;
        private Label labelRole;
        private Button buttonEdit;
        private Button buttonDelete;
    }
}
