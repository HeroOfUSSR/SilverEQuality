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
            this.labelDateBirth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAuthor = new System.Windows.Forms.PictureBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDateBirth
            // 
            this.labelDateBirth.AutoSize = true;
            this.labelDateBirth.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDateBirth.Location = new System.Drawing.Point(157, 109);
            this.labelDateBirth.Name = "labelDateBirth";
            this.labelDateBirth.Size = new System.Drawing.Size(127, 16);
            this.labelDateBirth.TabIndex = 9;
            this.labelDateBirth.Text = "25 июня 2023";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEdit);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(650, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 134);
            this.panel2.TabIndex = 6;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEdit.Location = new System.Drawing.Point(0, 70);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 32);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(0, 102);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 32);
            this.buttonDelete.TabIndex = 33;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxAuthor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 134);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxAuthor
            // 
            this.pictureBoxAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxAuthor.Image = global::SilverEQuality.Properties.Resources.profileMain;
            this.pictureBoxAuthor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAuthor.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxAuthor.Name = "pictureBoxAuthor";
            this.pictureBoxAuthor.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pictureBoxAuthor.Size = new System.Drawing.Size(153, 134);
            this.pictureBoxAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAuthor.TabIndex = 0;
            this.pictureBoxAuthor.TabStop = false;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.White;
            this.textBoxMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMail.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMail.Location = new System.Drawing.Point(166, 50);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.ReadOnly = true;
            this.textBoxMail.Size = new System.Drawing.Size(478, 23);
            this.textBoxMail.TabIndex = 8;
            this.textBoxMail.Text = "alexey_ivanov04@mail.ru";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.White;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.Location = new System.Drawing.Point(166, 79);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(478, 23);
            this.textBoxPhone.TabIndex = 11;
            this.textBoxPhone.Text = "89819748691";
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.BackColor = System.Drawing.Color.White;
            this.textBoxFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFullname.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFullname.Location = new System.Drawing.Point(166, 8);
            this.textBoxFullname.Multiline = true;
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.ReadOnly = true;
            this.textBoxFullname.Size = new System.Drawing.Size(478, 36);
            this.textBoxFullname.TabIndex = 12;
            this.textBoxFullname.Text = "Иванов Алексей Анатольевич\r\n";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRole.Location = new System.Drawing.Point(479, 109);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(137, 16);
            this.labelRole.TabIndex = 13;
            this.labelRole.Text = "Администратор";
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxFullname);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelDateBirth);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserView";
            this.Size = new System.Drawing.Size(800, 134);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
