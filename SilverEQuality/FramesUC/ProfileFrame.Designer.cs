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
            buttonChangeAv = new Button();
            labelDate = new Label();
            labelName = new Label();
            pictureBoxAvatar = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            openFileDialogChangeAv = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonChangeAv);
            panel1.Controls.Add(labelDate);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(pictureBoxAvatar);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1009, 121);
            panel1.TabIndex = 0;
            // 
            // buttonChangeAv
            // 
            buttonChangeAv.BackColor = SystemColors.ActiveCaption;
            buttonChangeAv.FlatAppearance.BorderSize = 0;
            buttonChangeAv.FlatStyle = FlatStyle.Flat;
            buttonChangeAv.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeAv.ForeColor = SystemColors.ControlLightLight;
            buttonChangeAv.Location = new Point(115, 68);
            buttonChangeAv.Name = "buttonChangeAv";
            buttonChangeAv.Size = new Size(207, 25);
            buttonChangeAv.TabIndex = 4;
            buttonChangeAv.Text = "Изменить фото";
            buttonChangeAv.UseVisualStyleBackColor = false;
            buttonChangeAv.Click += buttonChangeAv_Click;
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
            pictureBoxAvatar.Location = new Point(11, 5);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(98, 88);
            pictureBoxAvatar.TabIndex = 1;
            pictureBoxAvatar.TabStop = false;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 97);
            panel3.Name = "panel3";
            panel3.Size = new Size(1009, 24);
            panel3.TabIndex = 0;
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
            // ProfileFrame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ProfileFrame";
            Size = new Size(1009, 472);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
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
    }
}
