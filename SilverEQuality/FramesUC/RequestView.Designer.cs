namespace SilverEQuality.FramesUC
{
    partial class RequestView
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
            labelUserName = new Label();
            pictureBoxUser = new PictureBox();
            labelDateReq = new Label();
            buttonEdit = new Button();
            textBoxDescReq = new TextBox();
            labelRequestTitle = new Label();
            labelPriority = new Label();
            labelStatus = new Label();
            labelAmount = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(pictureBoxUser);
            panel1.Controls.Add(labelDateReq);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 173);
            panel1.TabIndex = 0;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(18, 126);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(117, 16);
            labelUserName.TabIndex = 5;
            labelUserName.Text = "Иванов А.А.";
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Dock = DockStyle.Top;
            pictureBoxUser.Image = Properties.Resources.profileMain;
            pictureBoxUser.Location = new Point(0, 0);
            pictureBoxUser.Margin = new Padding(10);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Padding = new Padding(25, 10, 25, 10);
            pictureBoxUser.Size = new Size(150, 116);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 4;
            pictureBoxUser.TabStop = false;
            // 
            // labelDateReq
            // 
            labelDateReq.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDateReq.AutoSize = true;
            labelDateReq.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateReq.Location = new Point(12, 155);
            labelDateReq.Name = "labelDateReq";
            labelDateReq.Size = new Size(127, 16);
            labelDateReq.TabIndex = 7;
            labelDateReq.Text = "25 июня 2023";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.SteelBlue;
            buttonEdit.DialogResult = DialogResult.OK;
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.ForeColor = SystemColors.ControlLightLight;
            buttonEdit.Location = new Point(625, 141);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(156, 32);
            buttonEdit.TabIndex = 33;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // textBoxDescReq
            // 
            textBoxDescReq.BackColor = Color.White;
            textBoxDescReq.BorderStyle = BorderStyle.None;
            textBoxDescReq.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescReq.Location = new Point(174, 86);
            textBoxDescReq.Multiline = true;
            textBoxDescReq.Name = "textBoxDescReq";
            textBoxDescReq.ReadOnly = true;
            textBoxDescReq.Size = new Size(426, 76);
            textBoxDescReq.TabIndex = 6;
            textBoxDescReq.Text = "Описание отсутствует";
            // 
            // labelRequestTitle
            // 
            labelRequestTitle.AutoSize = true;
            labelRequestTitle.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelRequestTitle.Location = new Point(173, 11);
            labelRequestTitle.Name = "labelRequestTitle";
            labelRequestTitle.Size = new Size(207, 19);
            labelRequestTitle.TabIndex = 5;
            labelRequestTitle.Text = "Запрос серебра ПСР";
            // 
            // labelPriority
            // 
            labelPriority.AutoSize = true;
            labelPriority.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPriority.Location = new Point(173, 43);
            labelPriority.Name = "labelPriority";
            labelPriority.Size = new Size(217, 16);
            labelPriority.TabIndex = 9;
            labelPriority.Text = "Приоритет отсутствует";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(173, 59);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(67, 16);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Статус";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Lucida Console", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAmount.Location = new Point(563, 11);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(185, 19);
            labelAmount.TabIndex = 10;
            labelAmount.Text = "Количество: 5000";
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(buttonEdit);
            Controls.Add(labelAmount);
            Controls.Add(labelPriority);
            Controls.Add(labelStatus);
            Controls.Add(textBoxDescReq);
            Controls.Add(labelRequestTitle);
            Controls.Add(panel1);
            Name = "RequestView";
            Size = new Size(780, 173);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelUserName;
        private PictureBox pictureBoxUser;
        private Label labelDateReq;
        private TextBox textBoxDescReq;
        private Label labelRequestTitle;
        private Label labelPriority;
        private Label labelStatus;
        private Label labelAmount;
        private Button buttonEdit;
    }
}
